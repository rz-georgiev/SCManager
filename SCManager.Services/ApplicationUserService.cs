using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System.Collections.Generic;

namespace SCManager.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly SCManagerDbContext _dbContext;

        public ApplicationUserService(SCManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ApplicationUser> GetAllApplicationUsers()
        {
            var users = _dbContext.ApplicationUsers;
            return users;
        }
    }
}