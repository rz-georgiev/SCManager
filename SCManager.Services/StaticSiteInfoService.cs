using Microsoft.EntityFrameworkCore;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System;
using System.Collections.Generic;
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

        public IEnumerable<StaticSiteInfo> GetAll()
        {
            return _context.StaticSiteInfos;
        }

        public async Task<StaticSiteInfo> GetByIdAsync(int? id)
        {
            return await _context.StaticSiteInfos
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<StaticSiteInfo> GetByNameAsync(string name)
        {
            return await _context.StaticSiteInfos
                .SingleOrDefaultAsync(x => x.Name == name);
        }

        public async Task<bool> SaveChangesAsync(StaticSiteInfo info)
        {
            try
            {
                _context.Update(info);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}