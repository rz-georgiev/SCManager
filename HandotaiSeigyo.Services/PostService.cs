using HandotaiSeigyo.Data;
using HandotaiSeigyo.Data.Interfaces;
using HandotaiSeigyo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HandotaiSeigyo.Services
{
    public class PostService : IPostService
    {
        private readonly HandotaiDbContext _context;

        public PostService(HandotaiDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Post> GetLastDayPosts()
        {
            return _context.Posts
                .Where(x => x.CreatedDateTime >= DateTime.Today);
        }
    }
}