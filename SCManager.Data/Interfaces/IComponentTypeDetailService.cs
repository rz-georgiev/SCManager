using SCManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface IComponentTypeDetailService
    {
        IEnumerable<ComponentTypeDetail> GetByComponentTypeId(int id);

        Task<ComponentTypeDetail> GetByIdAsync(int? id);

        Task<bool> SaveChangesAsync(ComponentTypeDetail detail);
    }
}