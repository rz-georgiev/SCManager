using SCManager.Data.Interfaces;
using SCManager.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SCManager.Data;
using AutoMapper;
using SCManager.Data.Models;
using System.Collections.Generic;

namespace SCManager.Controllers
{
    [Authorize(Roles = UserRights.Administrator)]
    public class AdminController : Controller
    {
        private readonly IUnitMultiplierService _unitMultipliersService;
        private readonly IComponentTypeService _componentTypesService;
        private readonly IComponentTypeDetailService _componentTypesDetailsService;
        private readonly IApplicationUserService _applicationUserService;
        private readonly IMapper _mapper;

        public AdminController(IComponentTypeService componentsService,
            IUnitMultiplierService unitMultipliersService,
            IComponentTypeDetailService detailsService,
            IApplicationUserService applicationUserService,
            IMapper mapper)
        {
            _unitMultipliersService = unitMultipliersService;
            _componentTypesService = componentsService;
            _componentTypesDetailsService = detailsService;
            _applicationUserService = applicationUserService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            //// TODO USE AUTO-MAPPER!!!
            //var unitMultipliers = _unitMultipliersService.GetAll();
            //var unitMultiplierModels = unitMultipliers.Select(x => new UnitMultiplierListingViewModel
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //    DateTime = x.LastUpdatedDateTime?.ToString("dd.MM.yyyy") ?? x.CreatedDateTime.ToString("dd.MM.yyyy")
            //});

            //var componentTypes = _componentTypesService.GetAll();
            //var componentTypeModels = componentTypes
            //    .Select(x => new ComponentTypeListingViewModel
            //    {
            //        Id = x.Id,
            //        Name = x.Name,
            //        ImagePath = x.ImagePath,
            //        DateTime = x.LastUpdatedDateTime?.ToString("dd.MM.yyyy") ?? x.CreatedDateTime.ToString("dd.MM.yyyy")
            //    });

            var applicationUsers = _applicationUserService.GetAllApplicationUsers();
            var model = new AdminTotalViewModel
            {
                Users = _mapper.Map<IEnumerable<UserViewModel>>(applicationUsers),
                //UnitMultipliers = unitMultiplierModels,
                //ComponentTypes = componentTypeModels
            };

            return View(model);
        }

        public IActionResult BanUser(string userId)
        {
            _applicationUserService.SetUserBanStatusAsync(userId, true);
            return View();
        }

        //public IActionResult UnbanUser(string userId)
        //{

        //}

        public IActionResult ComponentTypeEditor(int id)
        {
            var componentType = _componentTypesService.GetById(id);
            var componentTypeModel = new ComponentTypeListingViewModel
            {
                Id = componentType.Id,
                Name = componentType.Name,
                ImagePath = componentType.ImagePath,
                DateTime = componentType.LastUpdatedDateTime?.ToString("dd.MM.yyyy") ?? componentType.CreatedDateTime.ToString("dd.MM.yyyy")
            };

            var details = _componentTypesDetailsService.GetByComponentTypeId(componentType.Id);
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