using HandotaiSeigyo.Data.Interfaces;
using HandotaiSeigyo.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HandotaiSeigyo.Controllers
{
    // TODO REMOVE
    [AllowAnonymous]
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
                    DateTime = x.LastUpdatedDateTime?.ToString("dd.MM.yyyy") ?? x.CreatedDateTime.ToString("dd.MM.yyyy")
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
                DateTime = componentType.LastUpdatedDateTime?.ToString("dd.MM.yyyy") ?? componentType.CreatedDateTime.ToString("dd.MM.yyyy")
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