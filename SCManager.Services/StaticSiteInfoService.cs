using Microsoft.EntityFrameworkCore;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System.Threading.Tasks;

namespace SCManager.Services
{
    public class StaticSiteInfoService : IStaticSiteInfoService
    {
        private readonly SCManagerDbContext _context;

        public StaticSiteInfoService(SCManagerDbContext context)
        {
            _context = context;
        }

        public async Task<StaticSiteInfo> GetByNameAsync(string name)
        {
            return await _context.StaticSiteInfos
                .SingleOrDefaultAsync(x => x.Name == name);
        }

        public async Task CreateAsync(string name, string content)
        {
            throw new System.NotImplementedException();
        }
    }
}