using SCManager.Data.Models;
using System.Collections.Generic;

namespace SCManager.Data.Interfaces
{
    public interface IApplicationUserService
    {
        IEnumerable<ApplicationUser> GetAllApplicationUsers();
    }
}