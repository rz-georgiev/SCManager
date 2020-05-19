using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SCManager.Services
{
    public class PostService : IPostService
    {
        private readonly SCManagerDbContext _context;

        public PostService(SCManagerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts;
        }

        public IEnumerable<Post> GetLast15Posts()
        {
            return _context.Posts
                .OrderByDescending(x => x.Id)
                .Take(15);
        }
    }
}