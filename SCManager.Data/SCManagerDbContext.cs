using SCManager.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SCManager.Data
{
    public class SCManagerDbContext : IdentityDbContext<ApplicationUser>
    {
        public SCManagerDbContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<ComponentType> ComponentTypes { get; set; }

        public DbSet<ComponentTypeDetail> ComponentTypeDetails { get; set; }

        public DbSet<UserComponentType> UserComponentTypes { get; set; }

        public DbSet<UserComponentTypeDetail> UserComponentTypeDetails { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<UnitMultiplier> UnitMultipliers { get; set; }
    }
}