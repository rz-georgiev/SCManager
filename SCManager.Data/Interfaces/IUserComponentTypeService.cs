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

        Task SaveComponentAsync(UserComponentType type);

        Task UpdateComponentAsync(UserComponentType type);

        Task DeleteAsync(int id);
    }
}