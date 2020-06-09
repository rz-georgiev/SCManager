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

        public UnitMultiplier GetById(int? id)
        {
            return _context.UnitMultipliers
                .SingleOrDefault(x => x.Id == id);
        }

        public async Task<bool> SaveChangesAsync(UnitMultiplier type, bool isNew)
        {
            try
            {
                if (isNew)
                {
                    await _context.AddAsync(type);
                }
                else
                {
                    _context.Update(type);
                }

                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}