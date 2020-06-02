using SCManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface IApplicationUserService
    {
        IEnumerable<ApplicationUser> GetAllApplicationUsers();

        Task<bool> SetUserBanStatus(string userId, bool setToBanned);

    }
}