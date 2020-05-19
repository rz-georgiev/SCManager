using SCManager.Data.Models;
using System.Collections.Generic;

namespace SCManager.Data.Interfaces
{
    public interface IPostService
    {
        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetLast15Posts();
    }
}