using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandotaiSeigyo.ViewModels.Home
{
    public class PostViewModel
    {
        public IEnumerable<PostListingViewModel> FirstPosts { get; set; }

        public IEnumerable<PostListingViewModel> LastPosts { get; set; }
    }
}
