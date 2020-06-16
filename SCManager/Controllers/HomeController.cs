using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.ViewModels;
using SCManager.ViewModels.Home;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SCManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUserComponentTypeService _userComponentTypeService;
        private readonly IComponentTypeService _componentTypeService;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(IUserComponentTypeService userComponentTypeService,
            IComponentTypeService componentTypeService,
            UserManager<ApplicationUser> userManager)
        {
            _userComponentTypeService = userComponentTypeService;
            _componentTypeService = componentTypeService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);
           
            var userComponentTypes = _userComponentTypeService.GetAllForUserId(userId)
                .Include(x => x.ComponentType)
                .ToList();

            var types = userComponentTypes.Select(x => x.ComponentType);
            types = types.GroupBy(x => x.Id).Select(x => x.FirstOrDefault());

            var componentTypesModels = new List<UserComponentTypeViewModel>();
            foreach (var type in types)
            {
                decimal totalPrice = 0;
                var filteredUsedComponentTypes = userComponentTypes.Where(x => x.ComponentTypeId == type.Id);
            
                foreach (var filteredType in filteredUsedComponentTypes)
                    totalPrice += filteredType.Quantity * filteredType.UnitPrice;         

                var totalQuantity = filteredUsedComponentTypes
                    .Sum(x => x.Quantity);   

                componentTypesModels.Add(new UserComponentTypeViewModel
                {
                    TypeName = type.Name,
                    Quantity = totalQuantity,
                    TotalPrice = totalPrice
                });
            }
            var allQuantities = userComponentTypes.Sum(x => x.Quantity);

            foreach (var model in componentTypesModels)
                model.QuantityPercentage = (100 * model.Quantity) / allQuantities;

            var indexModel = new IndexViewModel
            {
                ComponentTypes = componentTypesModels
            };

            return View(indexModel);
        }

        public IActionResult Profile()
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