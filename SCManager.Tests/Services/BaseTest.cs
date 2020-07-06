using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SCManager.Data;

namespace SCManager.Tests.Services
{
    public abstract class BaseTest
    {
        protected readonly SCManagerDbContext SCManagerDbContext;

        protected BaseTest()
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            var options = new DbContextOptionsBuilder();
            options.UseSqlServer(configuration.GetConnectionString("SCManagerDbConnection"));

            SCManagerDbContext = new SCManagerDbContext(options.Options);
        }
    }
}