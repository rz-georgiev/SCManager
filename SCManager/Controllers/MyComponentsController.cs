using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.InputModels;
using SCManager.ViewModels.MyComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize]
    public class MyComponentsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IComponentTypeService _componentTypeService;
        private readonly IUnitMultiplierService _unitMultiplierService;
        private readonly IStaticSiteInfoService _staticSiteInfoService;
        private readonly IUserComponentTypeService _userComponentTypeService;
        private readonly IComponentTypeDetailService _componentTypeDetailService;
        private readonly ICloudinaryService _cloudinaryService;

        public MyComponentsController
        (
            UserManager<ApplicationUser> userManager,
            IMapper mapper,
            IComponentTypeService componentTypeService,
            IUnitMultiplierService unitMultiplierService,
            IStaticSiteInfoService staticSiteInfoService,
            IUserComponentTypeService userComponentTypeService,
            IComponentTypeDetailService componentTypeDetailService,
            ICloudinaryService cloudinaryService
        )
        {
            _userManager = userManager;
            _mapper = mapper;
            _componentTypeService = componentTypeService;
            _unitMultiplierService = unitMultiplierService;
            _staticSiteInfoService = staticSiteInfoService;
            _userComponentTypeService = userComponentTypeService;
            _componentTypeDetailService = componentTypeDetailService;
            _cloudinaryService = cloudinaryService;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);

            var userComponentTypes = _userComponentTypeService.GetAllForUserId(userId)
                .Include(x => x.UnitMultiplier)
                .Include(x => x.ComponentType)
                    .ThenInclude(x => x.Details)
                .ToList();

            userComponentTypes = userComponentTypes.OrderByDescending(x => x.Id).ToList();

            var componentModels = new List<ComponentViewModel>();
            userComponentTypes.ForEach(x =>
            {
                var type = x.ComponentType;
                var multiplier = x.UnitMultiplier;
                var typeDetail = type.Details.SingleOrDefault();

                componentModels.Add(new ComponentViewModel
                {
                    Id = x.Id,
                    Quantity = x.Quantity,
                    TotalPrice = x.Quantity * x.UnitPrice,
                    Name = type.Name,
                    Value = x.Value,
                    Unit = $"{multiplier.Name}{typeDetail.Symbol}"
                });
            });

            var model = new IndexViewModel
            {
                Components = componentModels
            };

            return View(model);
        }

        public async Task<IActionResult> MyComponent(int? userComponentTypeId)
        {
            var componentTypes = _componentTypeService.GetAll()
                .Include(x => x.Details);

            var multipliers = _unitMultiplierService.GetAll();

            var component = await _userComponentTypeService.GetByIdAsync(userComponentTypeId);
            if (component == null)
            {
                var defaultModel = new MyComponentInputModel
                {
                    ComponentTypes = componentTypes,
                    UnitMultipliers = multipliers
                };

                return View(defaultModel);
            }
            else
            {
                var model = new MyComponentInputModel
                {
                    Id = component.Id,
                    ComponentTypeId = component.ComponentTypeId,
                    Quantity = component.Quantity,
                    UnitMultiplierId = component.UnitMultiplierId,
                    UnitPrice = component.UnitPrice,
                    Value = component.Value,
                    ComponentTypes = componentTypes,
                    UnitMultipliers = multipliers
                };

                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> MyComponent(MyComponentInputModel model)
        {
            if (!ModelState.IsValid)
            {
                var componentTypes = _componentTypeService.GetAll().Include(x => x.Details);
                var multipliers = _unitMultiplierService.GetAll();

                model.ComponentTypes = componentTypes;
                model.UnitMultipliers = multipliers;

                return View(model);
            }

            var component = await _userComponentTypeService.GetByIdAsync(model.Id);
            var userId = _userManager.GetUserId(User);
            if (component == null)
            {
                component = new UserComponentType
                {
                    ComponentTypeId = model.ComponentTypeId,
                    Quantity = model.Quantity,
                    UnitMultiplierId = model.UnitMultiplierId,
                    UnitPrice = model.UnitPrice,
                    Value = model.Value,
                    CreatedByUserId = userId,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true
                };
            }
            else
            {
                component.ComponentTypeId = model.ComponentTypeId;
                component.Quantity = model.Quantity;
                component.UnitMultiplierId = model.UnitMultiplierId;
                component.UnitPrice = model.UnitPrice;
                component.Value = model.Value;
                component.LastUpdatedByUserId = userId;
                component.LastUpdatedDateTime = DateTime.UtcNow;
            }

            await _userComponentTypeService.SaveChangesAsync(component);

            return RedirectToAction("Index", "MyComponents");
        }
    }
}