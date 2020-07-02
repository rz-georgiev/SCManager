using Microsoft.EntityFrameworkCore;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

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

        public async Task<ComponentTypeDetail> GetByIdAsync(int? id)
        {
            return await _context.ComponentTypeDetails
                    .SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task ResetPrimaryStatuses(ComponentTypeDetail detail)
        {
            var details = _context.ComponentTypeDetails
                .Where(x => x.ComponentTypeId == detail.ComponentTypeId && x.Id != detail.Id);

            await details.ForEachAsync(x => x.IsPrimary = false);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }
        }

        public async Task<bool> SaveChangesAsync(ComponentTypeDetail detail)
        {
            try
            {
                if (detail == null)
                {
                    await _context.AddAsync(detail);
                }
                else
                {
                    _context.Update(detail);
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