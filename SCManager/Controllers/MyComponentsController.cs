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
        private readonly IUserComponentTypeDetailService _userComponentTypeDetailService;
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
            IUserComponentTypeDetailService userComponentTypeDetailService,
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
            _userComponentTypeDetailService = userComponentTypeDetailService;
            _componentTypeDetailService = componentTypeDetailService;
            _cloudinaryService = cloudinaryService;
        }

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);

            var userComponents = _userComponentTypeService.GetAllForUserId(userId)
                .Include(x => x.ComponentType)
                    .ThenInclude(x => x.Details)
                .Include(x => x.Details)
                    .ThenInclude(x => x.UnitMultiplier)
                .OrderByDescending(x => x.Id)
                .ToList();

            var models = new List<ComponentViewModel>();
            userComponents.ForEach(x =>
            {
                var type = x.ComponentType;
                var typeDetail = type.Details.SingleOrDefault(x => x.IsPrimary);
                var userDetail = x.Details.SingleOrDefault(x => x.ComponentTypeDetail.IsPrimary);
                var multiplier = userDetail.UnitMultiplier;
                var valueType = userDetail.ComponentTypeDetail.Name;

                models.Add(new ComponentViewModel
                {
                    Id = x.Id,
                    Name = type.Name,
                    Quantity = x.Quantity,
                    TotalPrice = x.UnitPrice * x.Quantity,
                    ValueType = valueType,
                    Value = userDetail.Value,
                    Multiplier = multiplier.Name,
                    Unit = typeDetail.Symbol
                });
            });

            var model = new IndexViewModel
            {
                Components = models
            };

            return View(model);
        }

        public async Task<IActionResult> MyComponent(int? userComponentTypeId)
        {
            var componentTypes = _componentTypeService.GetAll()
                .Include(x => x.Details)
                .Where(x => x.Details.Count(s => s.IsPrimary) > 0)
                .ToList();

            var multipliers = _unitMultiplierService.GetAll();

            var userComponent = await _userComponentTypeService.GetByIdAsync(userComponentTypeId);
            if (userComponent == null)
            {
                var defaultModel = new MyComponentInputModel
                {
                    ComponentTypes = componentTypes
                };

                return View(defaultModel);
            }
            else
            {
                var details = _userComponentTypeDetailService.GetByUserComponentTypeId(userComponent.Id);
                var inputDetails = details.Select(x => new MyComponentDetailInputModel
                {
                    DetailId = x.Id,
                    Name = x.ComponentTypeDetail.Name,
                    MultiplierId = x.UnitMultiplierId,
                    Unit = x.ComponentTypeDetail.Unit,
                    Value = x.Value
                }).ToList();

                var model = new MyComponentInputModel
                {
                    Id = userComponent.Id,
                    ComponentTypeId = userComponent.ComponentTypeId,
                    Quantity = userComponent.Quantity,
                    UnitPrice = userComponent.UnitPrice,
                    ComponentTypes = componentTypes,
                    UnitMultipliers = multipliers,
                    Details = inputDetails
                };

                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> MyComponent(MyComponentInputModel model)
        {
            if (!ModelState.IsValid)
            {
                var componentTypes = _componentTypeService.GetAll()
                    .Include(x => x.Details);

                var multipliers = _unitMultiplierService.GetAll();

                model.ComponentTypes = componentTypes;
                model.UnitMultipliers = multipliers;

                return View(model);
            }

            var userComponent = await _userComponentTypeService.GetByIdAsync(model.Id);
            var userId = _userManager.GetUserId(User);
            if (userComponent == null)
            {
                userComponent = new UserComponentType
                {
                    ComponentTypeId = model.ComponentTypeId,
                    Quantity = model.Quantity,
                    UnitPrice = model.UnitPrice,
                    CreatedByUserId = userId,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true
                };

                await _userComponentTypeService.SaveComponentAsync(userComponent);

                var type = await _componentTypeService.GetByIdAsync(model.ComponentTypeId);
                var details = _componentTypeDetailService.GetByComponentTypeId(type.Id);

                var userDetails = details.Select(x => new UserComponentTypeDetail
                {
                    UserComponentTypeId = userComponent.Id,
                    UnitMultiplierId = 1,
                    ComponentTypeDetailId = x.Id,
                    Value = 0,
                    CreatedByUserId = userId,
                    CreatedDateTime = DateTime.UtcNow,
                    IsActive = true
                });

                await _userComponentTypeDetailService.SaveDetailsAsync(userDetails);

                return Redirect($"/MyComponents/MyComponent?userComponentTypeId={userComponent.Id}");
            }
            else
            {
                userComponent.Quantity = model.Quantity;
                userComponent.UnitPrice = model.UnitPrice;
                userComponent.LastUpdatedByUserId = userId;
                userComponent.LastUpdatedDateTime = DateTime.UtcNow;

                var details = _userComponentTypeDetailService.GetByUserComponentTypeId(userComponent.Id);
                foreach (var detail in details)
                {
                    var detailModel = model.Details.SingleOrDefault(x => x.DetailId == detail.Id);
                    detail.UnitMultiplierId = detailModel.MultiplierId;
                    detail.Value = detailModel.Value;

                    detail.LastUpdatedByUserId = userId;
                    detail.LastUpdatedDateTime = DateTime.UtcNow;
                }

                await _userComponentTypeService.UpdateComponentAsync(userComponent);
                await _userComponentTypeDetailService.UpdateRangeAsync(details);

                return Redirect($"/MyComponents/Index");
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _userComponentTypeService.DeleteAsync(id);
            return Redirect("/MyComponents/Index");
        }
    }
}