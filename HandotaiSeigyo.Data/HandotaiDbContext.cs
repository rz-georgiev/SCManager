using HandotaiSeigyo.Data.Models;
using Microsoft.AspNetCore.Identity;
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

        //public DbSet<BaseEntity> BaseEntities { get; set; }

        //public DbSet<Component> Components { get; set; }

        //public DbSet<ComponentDetail> ComponentDetails { get; set; }

        //public DbSet<UserComponent> UserComponents { get; set; }

        //public DbSet<UserComponentDetail> UserComponentDetails { get; set; }
    }
}