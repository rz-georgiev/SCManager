using HandotaiSeigyo.Data;
using HandotaiSeigyo.Data.Interfaces;
using HandotaiSeigyo.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace HandotaiSeigyo.Services
{
    public class ComponentTypeService : IComponentTypeService
    {
        private readonly HandotaiDbContext _context;

        public ComponentTypeService(HandotaiDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ComponentType> GetAllComponentTypes()
        {
            return _context.ComponentTypes;
        }
    }
}