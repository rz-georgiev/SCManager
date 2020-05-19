using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SCManager.Services
{
    public class ComponentTypeService : IComponentTypeService
    {
        private readonly SCManagerDbContext _context;

        public ComponentTypeService(SCManagerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ComponentType> GetAll()
        {
            return _context.ComponentTypes;
        }

        public ComponentType GetById(int id)
        {
            return _context.ComponentTypes
                .SingleOrDefault(x => x.Id == id);
        }
    }
}