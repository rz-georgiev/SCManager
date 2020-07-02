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
    public class ComponentTypeService : IComponentTypeService
    {
        private readonly SCManagerDbContext _context;

        public ComponentTypeService(SCManagerDbContext context)
        {
            _context = context;
        }

        public IQueryable<ComponentType> GetAll()
        {
            return _context.ComponentTypes;
        }

        public async Task<ComponentType> GetByIdAsync(int? id)
        {
            return await _context.ComponentTypes
                .SingleOrDefaultAsync(x => x.Id == id);
        }

 
        public async Task<bool> SaveChangesAsync(ComponentType type)
        {
            try
            {
                if (type == null)
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
            catch (Exception)
            {
                return false;
            }
        }
    }
}