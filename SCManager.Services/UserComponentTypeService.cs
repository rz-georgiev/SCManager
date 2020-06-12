using Microsoft.EntityFrameworkCore;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System.Collections.Generic;
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
    }
}