using HandotaiSeigyo.Data.Interfaces;
using HandotaiSeigyo.Data.Models;
using HandotaiSeigyo.ViewModels;
using HandotaiSeigyo.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HandotaiSeigyo.Controllers
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
            var posts = _postsService.GetLastDayPosts();
            var count = posts.Count();

            var firstCount = count % 2 == 0 ? count / 2 : (count / 2) + 1;
            var secondCount = count - firstCount;

            var firstPosts = GetPostViewModels(posts.OrderByDescending(x => x.Id).Take(firstCount));
            var lastPosts = GetPostViewModels(posts.OrderBy(x => x.Id).Take(secondCount));

            var model = new PostViewModel { FirstPosts = firstPosts, LastPosts = lastPosts };

            return View(model);
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