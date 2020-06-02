using Microsoft.EntityFrameworkCore;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCManager.Services
{
    public class ApplicationUserService : IApplicationUserService
    {
        private readonly SCManagerDbContext _dbContext;

        public ApplicationUserService(SCManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> SetUserBanStatusAsync(string userId, bool setToBanned)
        {
            var user = await _dbContext.ApplicationUsers.FirstOrDefaultAsync(x => x.Id == userId);
            if (user == null)
                return false;

            user.IsBanned = setToBanned;
            _dbContext.Update(user);

            await _dbContext.SaveChangesAsync();
            return true;
        }


        public IEnumerable<ApplicationUser> GetAllApplicationUsers()
        {
            var users = _dbContext.ApplicationUsers;
            return users;
        }
    }
}