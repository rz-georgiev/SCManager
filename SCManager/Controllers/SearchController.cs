using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize]
    public class SearchController : Controller
    {
        private readonly ISearchService _searchService;
        private readonly UserManager<ApplicationUser> _userManager;

        public SearchController(ISearchService searchService,
            UserManager<ApplicationUser> userManager)
        {
            _searchService = searchService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            // var user = await _userManager.GetUserAsync(User);

            // var userComponentTypes = _searchService.GetUserComponentTypes(user.Id);
            // var componentTypes = _searchService.GetAllComponentTypes();

            var a = ViewBag.CurrentFilter;

            return View();
        }
    }
}