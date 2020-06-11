using SCManager.Data.Models;
using System.Collections.Generic;

namespace SCManager.Data.Interfaces
{
    public interface IUserComponentTypeService
    {
        IEnumerable<UserComponentType> GetAllForUserId(string userId);
    }
}