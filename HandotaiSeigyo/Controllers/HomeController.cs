using HandotaiSeigyo.Data.Interfaces;
using HandotaiSeigyo.Services;
using HandotaiSeigyo.ViewModels;
using HandotaiSeigyo.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
            var posts = _postsService.GetLastDayPosts()
                .Select(x => new PostListingViewModel
                {
                    Name = x.Name,
                    Description = x.Description,
                    ImagePath = x.ImagePath,
                    DateTime = x.CreatedDateTime.ToString("dd.MM.yyyy HH:mm")
                });

            var model = new PostViewModel { Posts = posts };

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
    }
}