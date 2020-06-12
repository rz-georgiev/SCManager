using Microsoft.EntityFrameworkCore;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Services
{
    public class UserComponentTypeService : IUserComponentTypeService
    {
        private readonly SCManagerDbContext _context;

        public UserComponentTypeService(SCManagerDbContext context)
        {
            _context = context;
        }

        public IQueryable<UserComponentType> GetAllForUserId(string userId)
        {
            var types = _context.UserComponentTypes
                .Where(x => x.CreatedByUserId == userId);

            return types;
        }

        public async Task<UserComponentType> GetByIdAsync(int? id)
        {
            var type = await _context.UserComponentTypes
                .SingleOrDefaultAsync(x => x.Id == id);

            return type;
        }

        public async Task<bool> SaveChangesAsync(UserComponentType type)
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
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}