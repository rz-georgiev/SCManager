using Microsoft.EntityFrameworkCore;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
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

        public async Task DeleteAllForUserIdAsync(string userId)
        {
            var types = _context.UserComponentTypes
                 .Where(x => x.CreatedByUserId == userId);

            if (types == null)
                return;

            _context.RemoveRange(types);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var userComponentType = await _context.UserComponentTypes
                .SingleOrDefaultAsync(x => x.Id == id);

            if (userComponentType == null)
                return;

            _context.Remove(userComponentType);
            await _context.SaveChangesAsync();
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

        public async Task SaveComponentAsync(UserComponentType type)
        {
            await _context.AddAsync(type);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateComponentAsync(UserComponentType type)
        {
            _context.UserComponentTypes.Update(type);
            await _context.SaveChangesAsync();
        }
    }
}