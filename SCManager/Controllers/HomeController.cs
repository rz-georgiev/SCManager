using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.ViewModels;
using SCManager.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SCManager.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IPostService _postsService;

        public HomeController(IPostService postService)
        {
            _postsService = postService;
        }

        public IActionResult Index()
        {
            var posts = _postsService.GetLast15Posts();
            var first = posts.Take(5);
            var second = posts.Skip(5).Take(5);
            var third = posts.Skip(10).Take(5);

            var result = new PostViewModel();
            result.PostLists = new List<List<PostListingViewModel>>
            {
                GetPostListingViewModels(first),
                GetPostListingViewModels(second),
                GetPostListingViewModels(third),
            };

            return View(result);
        }

        private List<PostListingViewModel> GetPostListingViewModels(IEnumerable<Post> posts)
        {
            var models = posts.Select(x => new PostListingViewModel
            {
                Name = x.Name,
                Description = x.Description,
                ImagePath = x.ImagePath,
                DateTime = x.CreatedDateTime.ToString("dd.MM.yyyy HH:mm")
            }).ToList();

            return models;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private IEnumerable<PostListingViewModel> GetPostViewModels(IEnumerable<Post> posts)
        {
            var newPosts = posts.OrderByDescending(x => x.Id)
               .Select(x => new PostListingViewModel
               {
                   Name = x.Name,
                   Description = x.Description,
                   ImagePath = x.ImagePath,
                   DateTime = x.CreatedDateTime.ToString("dd.MM.yyyy HH:mm")
               });

            return newPosts;
        }
    }
}