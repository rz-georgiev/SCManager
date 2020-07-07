using SCManager.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface IUserComponentTypeService
    {
        IQueryable<UserComponentType> GetAllForUserId(string userId);
       
        Task<UserComponentType> GetByIdAsync(int? typeId);

        Task<bool> SaveComponentAsync(UserComponentType type);

        Task<bool> UpdateComponentAsync(UserComponentType type);

        Task<bool> DeleteAsync(int id);

        Task<bool> DeleteAllForUserIdAsync(string userId);
    }
}