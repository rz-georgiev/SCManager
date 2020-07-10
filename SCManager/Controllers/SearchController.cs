using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.ViewModels.Search;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IActionResult> Index(string searchText)
        {
            searchText = searchText.ToLower();
            var user = await _userManager.GetUserAsync(User);

            var userComponentTypes = _searchService
                .GetUserComponentTypes(user.Id)
                .Include(x => x.ComponentType)
                .Where(x => x.ComponentType.Name
                .ToLower()
                .Contains(searchText));

            var componentTypes = _searchService
                .GetAllComponentTypes()
                .Where(x => x.Name.ToLower()
                .Contains(searchText));

            var models = new List<ComponentViewModel>();
            await userComponentTypes.ForEachAsync(x =>
            {
                models.Add(new ComponentViewModel
                {
                    Id = x.Id,
                    ComponentName = x.ComponentType.Name,
                    Quantity = x.Quantity,
                    SearchType = Data.Enums.SearchType.MyComponent
                });
            });

            await componentTypes.ForEachAsync(x =>
            {
                models.Add(new ComponentViewModel
                {
                    Id = x.Id,
                    ComponentName = x.Name,
                    Quantity = null,
                    SearchType = Data.Enums.SearchType.Component
                });
            });

            var model = new IndexViewModel { Models = models };

            return View(model);
        }
    }
}