using SCManager.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface IComponentTypeService
    {
        IQueryable<ComponentType> GetAll();

        Task<ComponentType> GetByIdAsync(int? id);
  
        Task<bool> SaveChangesAsync(ComponentType type);
    }
}