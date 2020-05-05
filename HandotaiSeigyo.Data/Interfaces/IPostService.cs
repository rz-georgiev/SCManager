using HandotaiSeigyo.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandotaiSeigyo.Data.Interfaces
{
    public interface IPostService
    {
        IEnumerable<Post> GetLast15Posts();
    }
}
