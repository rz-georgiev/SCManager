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

            var connectionString = configuration.GetConnectionString("SCManagerDbConnection");

            var options = new DbContextOptionsBuilder();
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            SCManagerDbContext = new SCManagerDbContext(options.Options);
        }
    }
}