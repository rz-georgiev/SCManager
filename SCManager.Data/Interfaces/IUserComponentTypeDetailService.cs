using SCManager.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface IUserComponentTypeDetailService
    {
        Task SaveDetailsAsync(IEnumerable<UserComponentTypeDetail> details);

        IEnumerable<UserComponentTypeDetail> GetByUserComponentTypeId(int? typeId);

        Task UpdateRangeAsync(IEnumerable<UserComponentTypeDetail> details);
    }
}