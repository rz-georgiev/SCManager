using SCManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface IUserComponentTypeDetailService
    {
        Task<bool> SaveDetailsAsync(IEnumerable<UserComponentTypeDetail> details);

        IEnumerable<UserComponentTypeDetail> GetByUserComponentTypeId(int? typeId);

        Task<bool> UpdateRangeAsync(IEnumerable<UserComponentTypeDetail> details);
    }
}