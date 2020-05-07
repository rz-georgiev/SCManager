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