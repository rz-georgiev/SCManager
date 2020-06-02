using SCManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface IApplicationUserService
    {
        IEnumerable<ApplicationUser> GetAllApplicationUsers();

       

        Task<bool> SetUserBanStatusAsync(string userId, bool setToBanned);

    }
}