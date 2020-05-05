using HandotaiSeigyo.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HandotaiSeigyo.Data
{
    public class HandotaiDbContext : IdentityDbContext
    {
        public HandotaiDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<ComponentType> ComponentTypes { get; set; }

        public DbSet<ComponentTypeDetail> ComponentTypeDetails { get; set; }

        public DbSet<UserComponentType> UserComponentTypes { get; set; }

        public DbSet<UserComponentTypeDetail> UserComponentTypeDetails { get; set; }

        public DbSet<Post> Posts { get; set; }
    }
}