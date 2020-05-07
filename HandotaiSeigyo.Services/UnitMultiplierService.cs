using HandotaiSeigyo.Data;
using HandotaiSeigyo.Data.Interfaces;
using HandotaiSeigyo.Data.Models;
using System.Collections.Generic;

namespace HandotaiSeigyo.Services
{
    public class UnitMultiplierService : IUnitMultiplierService
    {
        private readonly HandotaiDbContext _context;

        public UnitMultiplierService(HandotaiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UnitMultiplier> GetAll()
        {
            return _context.UnitMultipliers;
        }
    }
}