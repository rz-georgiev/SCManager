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

        public async Task<UserComponentType> GetByIdAsync(int? id)
        {
            var type = await _context.UserComponentTypes
                .SingleOrDefaultAsync(x => x.Id == id);

            return type;
        }

        public IQueryable<UserComponentType> GetAllForUserId(string userId)
        {
            var types = _context.UserComponentTypes
                .Where(x => x.CreatedByUserId == userId);

            return types;
        }

        public async Task<bool> SaveComponentAsync(UserComponentType type)
        {
            try
            {
                await _context.AddAsync(type);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> UpdateComponentAsync(UserComponentType type)
        {
            try
            {
                _context.UserComponentTypes.Update(type);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var userComponentType = await _context.UserComponentTypes
                .SingleOrDefaultAsync(x => x.Id == id);

                if (userComponentType == null)
                    return false;

                _context.Remove(userComponentType);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAllForUserIdAsync(string userId)
        {
            try
            {
                var types = _context.UserComponentTypes
               .Where(x => x.CreatedByUserId == userId);

                if (!types.Any())
                    return false;

                _context.RemoveRange(types);
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