using HandotaiSeigyo.Data;
using HandotaiSeigyo.Data.Interfaces;
using HandotaiSeigyo.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HandotaiSeigyo.Services
{
    public class ComponentTypeService : IComponentTypeService
    {
        private readonly HandotaiDbContext _context;

        public ComponentTypeService(HandotaiDbContext context)
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