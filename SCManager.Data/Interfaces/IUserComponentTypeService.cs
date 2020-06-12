using SCManager.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCManager.Data.Interfaces
{
    public interface IUserComponentTypeService
    {
        IQueryable<UserComponentType> GetAllForUserId(string userId);
    }
}