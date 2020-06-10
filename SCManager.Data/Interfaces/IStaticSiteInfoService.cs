using SCManager.Data.Models;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface IStaticSiteInfoService
    {
        Task<StaticSiteInfo> GetByNameAsync(string name);

        Task<StaticSiteInfo> GetByIdAsync(int? id);

        Task<bool> SaveChangesAsync(StaticSiteInfo info);
    }
}