using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public ComponentType GetById(int? id)
        {
            return _context.ComponentTypes
                .SingleOrDefault(x => x.Id == id);
        }

        public async Task<bool> SaveChangesAsync(ComponentType type, bool isNew)
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