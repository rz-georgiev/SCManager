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
            searchText = searchText?.ToLower();
            var user = await _userManager.GetUserAsync(User);

            var userComponentTypes = _searchService.GetUserComponentTypes(user.Id)
                .Include(x => x.ComponentType)
                    .ThenInclude(x => x.Details)
                .Include(x => x.Details)
                    .ThenInclude(x => x.UnitMultiplier)
                .Where(x => x.ComponentType.Name
                .ToLower()
                .Contains(searchText))
                .OrderByDescending(x => x.Id);

            var models = new List<ComponentViewModel>();
            await userComponentTypes.ForEachAsync(x =>
            {
                var type = x.ComponentType;
                var typeDetail = type.Details.SingleOrDefault(x => x.IsPrimary);
                var userDetail = x.Details.SingleOrDefault(x => x.ComponentTypeDetail.IsPrimary);
                var multiplier = userDetail.UnitMultiplier;
                var valueType = userDetail.ComponentTypeDetail.Name;

                models.Add(new ComponentViewModel
                {
                    Id = x.Id,
                    ComponentName = x.ComponentType.Name,
                    Quantity = x.Quantity,
                    TotalPrice = x.UnitPrice * x.Quantity,
                    ValueType = valueType,
                    Value = userDetail.Value,
                    Multiplier = multiplier.Name,
                    Unit = typeDetail.Symbol,
                    SearchType = Data.Enums.SearchType.MyComponent
                });
            });

            var componentTypes = _searchService
              .GetAllComponentTypes()
              .Where(x => x.Name.ToLower()
              .Contains(searchText));

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