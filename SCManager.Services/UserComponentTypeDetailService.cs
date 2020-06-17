using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Services
{
    public class UserComponentTypeDetailService : IUserComponentTypeDetailService
    {
        private readonly SCManagerDbContext _context;

        public UserComponentTypeDetailService(SCManagerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UserComponentTypeDetail> GetByUserComponentTypeId(int? id)
        {
            return _context.UserComponentTypeDetails
                .Where(x => x.UserComponentTypeId == id);
        }

        public async Task SaveDetailsAsync(IEnumerable<UserComponentTypeDetail> details)
        {
            await _context.UserComponentTypeDetails.AddRangeAsync(details);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(IEnumerable<UserComponentTypeDetail> details)
        {
            _context.UserComponentTypeDetails.UpdateRange(details);
            await _context.SaveChangesAsync();
        }
    }
}