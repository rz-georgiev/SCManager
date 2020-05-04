using HandotaiSeigyo.Data.Interfaces;
using HandotaiSeigyo.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HandotaiSeigyo.Controllers
{
    public class AdminController : Controller
    {
        private readonly IComponentTypeService _service;

        public AdminController(IComponentTypeService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var listingModels = _service.GetAllComponentTypes()
                .Select(x => new ComponentTypeListingViewModel
                {
                    Name = x.Name,
                    ImagePath = x.ImagePath,
                    DateTime = x.LastUpdatedDateTime?.ToString("r") ?? x.CreatedDateTime.ToString("r")
                }).ToList();

            var model = new ComponentTypeViewModel { ListingModels = listingModels };

            return View(model);
        }
    }
}