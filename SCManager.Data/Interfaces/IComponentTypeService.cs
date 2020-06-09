using SCManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface IComponentTypeService
    {
        IEnumerable<ComponentType> GetAll();

        ComponentType GetById(int? id);

        Task<bool> SaveChangesAsync(ComponentType type, bool isNew);
    }
}