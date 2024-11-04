using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SCManager.Data.Models;
using System.Collections.Generic;
using System.Web;

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
            var unitMultipliers = GetDeserializedObjects<UnitMultiplier>(SeedingResources.UnitMultipliers);
            var componentTypes = GetDeserializedObjects<ComponentType>(SeedingResources.ComponentTypes);
            var componentTypeDetails = GetDeserializedObjects<ComponentTypeDetail>(SeedingResources.ComponentTypeDetails);
            var userComponentTypes = GetDeserializedObjects<UserComponentType>(SeedingResources.UserComponentTypes);
            var userComponentTypeDetails = GetDeserializedObjects<UserComponentTypeDetail>(SeedingResources.UserComponentTypeDetails);
            var staticSiteInfo = GetDeserializedObjects<StaticSiteInfo>(SeedingResources.StaticSiteInfos);

            builder.Entity<ApplicationUser>().HasData(users);
            builder.Entity<IdentityRole>().HasData(roles);
            builder.Entity<IdentityUserRole<string>>().HasData(usersRoles);
            builder.Entity<UnitMultiplier>().HasData(unitMultipliers);
            builder.Entity<ComponentType>().HasData(componentTypes);
            builder.Entity<ComponentTypeDetail>().HasData(componentTypeDetails);
            builder.Entity<UserComponentType>().HasData(userComponentTypes);
            builder.Entity<UserComponentTypeDetail>().HasData(userComponentTypeDetails);
            builder.Entity<StaticSiteInfo>().HasData(staticSiteInfo);
        }

        private IEnumerable<T> GetDeserializedObjects<T>(string resourceValue) where T : class
        {
             var objects = JsonConvert.DeserializeObject<List<T>>(resourceValue);
            return objects;
        }

        public DbSet<ComponentType> ComponentTypes { get; set; }

        public DbSet<ComponentTypeDetail> ComponentTypeDetails { get; set; }

        public DbSet<UserComponentType> UserComponentTypes { get; set; }

        public DbSet<UserComponentTypeDetail> UserComponentTypeDetails { get; set; }

        public DbSet<UnitMultiplier> UnitMultipliers { get; set; }

        public DbSet<StaticSiteInfo> StaticSiteInfos { get; set; }


        public DbSet<RequestLogEntry> RequestLogEntries { get; set; }
        
    }
}