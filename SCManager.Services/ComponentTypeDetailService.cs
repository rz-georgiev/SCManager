using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace SCManager.Services
{
    public class ComponentTypeDetailService : IComponentTypeDetailService
    {
        private readonly SCManagerDbContext _context;

        public ComponentTypeDetailService(SCManagerDbContext context)
        {
            _context = context;
        }
        public IEnumerable<ComponentTypeDetail> GetByComponentTypeId(int id)
        {
            return _context.ComponentTypeDetails
                .Where(x => x.ComponentType.Id == id);
        }
    }
}