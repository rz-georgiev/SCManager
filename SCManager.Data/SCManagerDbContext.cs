using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SCManager.Data.Models;

namespace SCManager.Data
{
    public class SCManagerDbContext : IdentityDbContext<ApplicationUser>
    {
        public SCManagerDbContext(DbContextOptions options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<ComponentType> ComponentTypes { get; set; }

        public DbSet<ComponentTypeDetail> ComponentTypeDetails { get; set; }

        public DbSet<UserComponentType> UserComponentTypes { get; set; }

        public DbSet<UserComponentTypeDetail> UserComponentTypeDetails { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<UnitMultiplier> UnitMultipliers { get; set; }

        public DbSet<StaticSiteInfo> StaticSiteInfos { get; set; }
    }
}