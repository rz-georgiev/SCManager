using AutoMapper;
using CloudinaryDotNet;
using Ganss.Xss;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.Services;
using System;

namespace SCManager
{
    public class Startup
    {
        private IServiceCollection _services;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            _services = services;

            ConfigureCookiePolicyOptions();
            ConfigureDbContext();
            ConfigureIdentityRolesOptions();
            ConfigureConcreteServices();

            services.AddResponseCompression(options => options.EnableForHttps = true);
            services.Configure<DataProtectionTokenProviderOptions>(o => o.TokenLifespan = TimeSpan.FromMinutes(5));
            services.AddAutoMapper(typeof(Startup));

            ConfigureControllers();

            services.AddRazorPages();

            ConfigureIdentityOptions();
            ConfigureCookies();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseStatusCodePagesWithRedirects("/Error/Index/{0}");
                app.UseExceptionHandler("/Error/Index");
                app.UseHsts();
            }

            app.UseResponseCompression();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "MyArea",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }

        // Separating the ConfigureServices method into different pieces
        // Its too damn big otherwise.
        private void ConfigureCookiePolicyOptions()
        {
            _services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential
                // cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;

                // requires using Microsoft.AspNetCore.Http;
                //options.MinimumSameSitePolicy = SameSiteMode.None;
                //options.Secure = CookieSecurePolicy.Always;
            });
        }

        private void ConfigureDbContext()
        {
            var connectionString = Configuration.GetConnectionString("SCManagerDbConnection");
            _services.AddDbContext<SCManagerDbContext>
            (
                options => options
                .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            );
        }

        private void ConfigureIdentityRolesOptions()
        {
            _services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
               .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<SCManagerDbContext>();
        }

        private void ConfigureConcreteServices()
        {
            Account account = new Account(
                    Configuration["Cloudinary:CloudName"],
                    Configuration["Cloudinary:ApiKey"],
                    Configuration["Cloudinary:ApiSecret"]);

            var cloudinary = new Cloudinary(account);

            _services.AddSingleton(cloudinary);
            _services.AddSingleton(new HtmlSanitizer());
            _services.AddSingleton<ICloudinaryService, CloudinaryService>();
            _services.AddSingleton<ISmtpService, SmtpService>();

            _services.AddTransient<IUnitMultiplierService, UnitMultiplierService>();
            _services.AddTransient<IComponentTypeService, ComponentTypeService>();
            _services.AddTransient<IComponentTypeDetailService, ComponentTypeDetailService>();
            _services.AddTransient<IStaticSiteInfoService, StaticSiteInfoService>();
            _services.AddTransient<IUserComponentTypeService, UserComponentTypeService>();
            _services.AddTransient<IUserComponentTypeDetailService, UserComponentTypeDetailService>();
            _services.AddTransient<ISearchService, SearchService>();
        }

        private void ConfigureControllers()
        {
            _services.AddControllers(config =>
            {
                // using Microsoft.AspNetCore.Mvc.Authorization;
                // using Microsoft.AspNetCore.Authorization;
                var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
                config.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });
        }

        private void ConfigureIdentityOptions()
        {
            _services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });
        }

        private void ConfigureCookies()
        {
            _services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            _services.Configure<CookieTempDataProviderOptions>(options =>
            {
                options.Cookie.IsEssential = true;
            });
        }
    }
}