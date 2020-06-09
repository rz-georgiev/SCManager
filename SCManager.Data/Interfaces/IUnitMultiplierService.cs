using SCManager.Data.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface IUnitMultiplierService
    {
        IEnumerable<UnitMultiplier> GetAll();

        Task<UnitMultiplier> GetByIdAsync(int? id);

        Task<bool> SaveChangesAsync(UnitMultiplier type, bool isNew);
    }
}