using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SCManager.Data.Models;
using System.Collections.Generic;

namespace SCManager.Data
{
    public class SCManagerDbContext : IdentityDbContext<ApplicationUser>
    {
        public SCManagerDbContext(DbContextOptions options)
            : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var users = GetDeserializedObjects<ApplicationUser>(SeedingResources.AspNetUsers);
            var roles = GetDeserializedObjects<IdentityRole>(SeedingResources.AspNetRoles);
            var usersRoles = GetDeserializedObjects<IdentityUserRole<string>>(SeedingResources.AspNetUserRoles);
            var siteInfos = GetDeserializedObjects<StaticSiteInfo>(SeedingResources.StaticSiteInfos);

            builder.Entity<ApplicationUser>().HasData(users);
            builder.Entity<IdentityRole>().HasData(roles);
            builder.Entity<IdentityUserRole<string>>().HasData(usersRoles);
            builder.Entity<StaticSiteInfo>().HasData(siteInfos);
        }

        private IEnumerable<T> GetDeserializedObjects<T>(string resourceValue) where T : class
        {
            var objects = JsonConvert.DeserializeObject<List<T>>(resourceValue);
            return objects;
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<ComponentType> ComponentTypes { get; set; }

        public DbSet<ComponentTypeDetail> ComponentTypeDetails { get; set; }

        public DbSet<UserComponentType> UserComponentTypes { get; set; }

        public DbSet<UserComponentTypeDetail> UserComponentTypeDetails { get; set; }

        public DbSet<UnitMultiplier> UnitMultipliers { get; set; }

        public DbSet<StaticSiteInfo> StaticSiteInfos { get; set; }
    }
}