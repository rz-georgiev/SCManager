using HandotaiSeigyo.Data;
using HandotaiSeigyo.Data.Interfaces;
using HandotaiSeigyo.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace HandotaiSeigyo.Services
{
    public class ComponentTypeDetailService : IComponentTypeDetailService
    {
        private readonly HandotaiDbContext _context;

        public ComponentTypeDetailService(HandotaiDbContext context)
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