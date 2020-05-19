using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System.Collections.Generic;

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
    }
}