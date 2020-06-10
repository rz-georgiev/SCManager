using SCManager.Data.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCManager.Data.Interfaces
{
    public interface IStaticSiteInfoService
    {
        IEnumerable<StaticSiteInfo> GetAll();

        Task<StaticSiteInfo> GetByNameAsync(string name);
        

        Task<StaticSiteInfo> GetByIdAsync(int? id);

        Task<bool> SaveChangesAsync(StaticSiteInfo info);
    }
}