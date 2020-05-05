using HandotaiSeigyo.Data.Interfaces;
using HandotaiSeigyo.ViewModels.Admin;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HandotaiSeigyo.Controllers
{
    public class AdminController : Controller
    {
        private readonly IComponentTypeService _componentsService;
        private readonly IComponentTypeDetailService _detailsService;

        public AdminController(IComponentTypeService componentsService, IComponentTypeDetailService detailsService)
        {
            _componentsService = componentsService;
            _detailsService = detailsService;
        }

        public IActionResult Index()
        {
            var listingModels = _componentsService.GetAll()
                .Select(x => new ComponentTypeListingViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ImagePath = x.ImagePath,
                    DateTime = x.LastUpdatedDateTime?.ToString("r") ?? x.CreatedDateTime.ToString("r")
                }).ToList();

            var model = new ComponentTypeViewModel { ListingModels = listingModels };

            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var componentType = _componentsService.GetById(id);
            var componentTypeModel = new ComponentTypeListingViewModel
            {
                Id = componentType.Id,
                Name = componentType.Name,
                ImagePath = componentType.ImagePath,
                DateTime = componentType.LastUpdatedDateTime?.ToString("r") ?? componentType.CreatedDateTime.ToString("r")
            };

            var details = _detailsService.GetByComponentTypeId(componentType.Id);
            var detailsModels = details.Select(x => new ComponentTypeDetailListingViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Unit = x.Unit
            });

            var resultModel = new ComponentTypeDetailViewModel
            {
                ComponentTypeModel = componentTypeModel,
                DetailModels = detailsModels
            };

            return View(resultModel);
        }
    }
}