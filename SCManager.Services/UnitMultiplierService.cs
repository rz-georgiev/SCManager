using Microsoft.EntityFrameworkCore;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Services
{
    public class UnitMultiplierService : IUnitMultiplierService
    {
        private readonly SCManagerDbContext _context;

        public UnitMultiplierService(SCManagerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UnitMultiplier> GetAll()
        {
            return _context.UnitMultipliers;
        }

        public async Task<UnitMultiplier> GetByIdAsync(int? id)
        {
            return await _context.UnitMultipliers
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> SaveChangesAsync(UnitMultiplier multiplier)
        {
            try
            {
                if (multiplier.Id == 0)
                {
                    await _context.AddAsync(multiplier);
                }
                else
                {
                    _context.Update(multiplier);
                }

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