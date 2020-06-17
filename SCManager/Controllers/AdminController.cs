using AutoMapper;
using Ganss.XSS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.InputModels;
using SCManager.RequestModels;
using SCManager.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize(Roles = AppUserRoles.Administrator)]
    public class AdminController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IComponentTypeService _componentTypeService;
        private readonly IUnitMultiplierService _unitMultiplierService;
        private readonly IStaticSiteInfoService _staticSiteInfoService;
        private readonly IComponentTypeDetailService _componentTypeDetailService;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly HtmlSanitizer _htmlSanitizer;

        public AdminController
        (
            UserManager<ApplicationUser> userManager,
            IMapper mapper,
            IComponentTypeService componentTypeService,
            IUnitMultiplierService unitMultiplierService,
            IStaticSiteInfoService staticSiteInfoService,
            IComponentTypeDetailService componentTypeDetailService,
            ICloudinaryService cloudinaryService,
            HtmlSanitizer htmlSanitizer
        )
        {
            _userManager = userManager;
            _mapper = mapper;
            _componentTypeService = componentTypeService;
            _unitMultiplierService = unitMultiplierService;
            _staticSiteInfoService = staticSiteInfoService;
            _componentTypeDetailService = componentTypeDetailService;
            _cloudinaryService = cloudinaryService;
            _htmlSanitizer = htmlSanitizer;
        }

        public async Task<IActionResult> Index()
        {
            var users = _mapper.Map<IEnumerable<UserViewModel>>(_userManager.Users);
            var administrators = await _userManager.GetUsersInRoleAsync(AppUserRoles.Administrator);
            var administratorsIds = administrators.Select(x => x.Id).ToList();

            var componentTypes = _componentTypeService.GetAll();
            var componentTypeModels = _mapper.Map<IEnumerable<ComponentTypeViewModel>>(componentTypes);
            var unitMultipliers = _mapper.Map<IEnumerable<UnitMultiplierViewModel>>(_unitMultiplierService.GetAll());
            var staticSiteInfos = _mapper.Map<IEnumerable<StaticSiteInfoViewModel>>(_staticSiteInfoService.GetAll());

            foreach (var user in users)
                user.IsAdmin = administratorsIds.Contains(user.Id);

            foreach (var componentTypeModel in componentTypeModels)
            {
                var imageId = componentTypes.SingleOrDefault(x => x.Id == componentTypeModel.Id)?.ImageId;
                componentTypeModel.ImageUrl = $"{Constants.BaseImageUrl}{imageId}";
            }

            foreach (var info in staticSiteInfos)
                info.Content = info.Content.Length > 100 ? $"{info.Content.Substring(0, 100)}...." : info.Content;

            var model = new IndexViewModel
            {
                Users = users,
                ComponentTypes = componentTypeModels,
                UnitMultipliers = unitMultipliers,
                StaticSiteInfos = staticSiteInfos
            };

            return View(model);
        }

        public async Task<IActionResult> ComponentType(int? componentTypeId)
        {
            var type = await _componentTypeService.GetByIdAsync(componentTypeId);
            if (type == null)
            {
                return View();
            }
            else
            {
                var details = _componentTypeDetailService.GetByComponentTypeId(type.Id);
                var inputDetails = _mapper.Map<IEnumerable<ComponentTypeDetailInputModel>>(details);

                var model = _mapper.Map<ComponentTypeInputModel>(type);
                model.Details = inputDetails;

                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ComponentType(ComponentTypeInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var newImageId = model.Image != null
                   ? await _cloudinaryService.UploadImageAsync(model.Image)
                   : null;

            var type = await _componentTypeService.GetByIdAsync(model.Id);
            if (type == null)
            {
                type = new ComponentType
                {
                    Name = model.Name,
                    ImageId = newImageId,
                    CreatedDateTime = DateTime.UtcNow,
                    CreatedByUserId = _userManager.GetUserId(User),
                    IsActive = true
                };
            }
            else
            {
                type.Name = model.Name;

                if (type.ImageId != null && newImageId != null)
                {
                    await _cloudinaryService.DeleteImageAsync(type.ImageId);
                    type.ImageId = newImageId;
                }
                else
                {
                    type.ImageId = newImageId ?? type.ImageId;
                }

                type.LastUpdatedDateTime = DateTime.UtcNow;
                type.LastUpdatedByUserId = _userManager.GetUserId(User);
            }

            await _componentTypeService.SaveChangesAsync(type);

            return Redirect($"/Admin/ComponentType?componentTypeId={type.Id}");
        }

        public async Task<IActionResult> ComponentTypeDetail(int? componentTypeDetailId,
            int componentTypeId)
        {
            var detail = await _componentTypeDetailService.GetByIdAsync(componentTypeDetailId);
            if (detail == null)
            {
                var model = new ComponentTypeDetailInputModel { ComponentTypeId = componentTypeId };
                return View(model);
            }
            else
            {
                var model = _mapper.Map<ComponentTypeDetailInputModel>(detail);
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> ComponentTypeDetail(ComponentTypeDetailInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var detail = await _componentTypeDetailService.GetByIdAsync(model.Id);
            if (detail == null)
            {
                detail = new ComponentTypeDetail
                {
                    Name = model.Name,
                    Unit = model.Unit,
                    Symbol = model.Symbol,
                    IsPrimary = model.IsPrimary,
                    ComponentTypeId = model.ComponentTypeId,
                    CreatedDateTime = DateTime.UtcNow,
                    CreatedByUserId = _userManager.GetUserId(User),
                    IsActive = true
                };
            }
            else
            {
                detail.Name = model.Name;
                detail.Unit = model.Unit;
                detail.Symbol = model.Symbol;
                detail.IsPrimary = model.IsPrimary;

                detail.LastUpdatedDateTime = DateTime.UtcNow;
                detail.LastUpdatedByUserId = _userManager.GetUserId(User);
            }

           
            await _componentTypeDetailService.SaveChangesAsync(detail);
            if (detail.IsPrimary)
            {
                await _componentTypeDetailService.ResetPrimaryStatuses(detail);
            }

            return Redirect($"/Admin/ComponentType?componentTypeId={model.ComponentTypeId}");
        }

        public async Task<IActionResult> UnitMultiplier(int? multiplierId)
        {
            var multiplier = await _unitMultiplierService.GetByIdAsync(multiplierId);
            if (multiplier == null)
            {
                return View();
            }
            else
            {
                var model = _mapper.Map<UnitMultiplierInputModel>(multiplier);
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> UnitMultiplier(UnitMultiplierInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var multiplier = await _unitMultiplierService.GetByIdAsync(model.Id);

            if (multiplier == null)
            {
                multiplier = new UnitMultiplier
                {
                    Name = model.Name,
                    CreatedDateTime = DateTime.UtcNow,
                    CreatedByUserId = _userManager.GetUserId(User),
                    IsActive = true
                };
            }
            else
            {
                multiplier.Name = model.Name;
                multiplier.LastUpdatedDateTime = DateTime.UtcNow;
                multiplier.LastUpdatedByUserId = _userManager.GetUserId(User);
            }

            await _unitMultiplierService.SaveChangesAsync(multiplier);

            return RedirectToAction("Index", "Admin");
        }

        public async Task<IActionResult> StaticSiteInfo(int? infoId)
        {
            var info = await _staticSiteInfoService.GetByIdAsync(infoId);
            if (info == null)
            {
                return View();
            }
            else
            {
                var model = _mapper.Map<StaticSiteInfoInputModel>(info);
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> StaticSiteInfo(StaticSiteInfoInputModel model)
        {
            model.Content = _htmlSanitizer.Sanitize(model.Content);

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var info = await _staticSiteInfoService.GetByIdAsync(model.Id);

            info.Content = model.Content;
            info.LastUpdatedDateTime = DateTime.UtcNow;
            info.LastUpdatedByUserId = _userManager.GetUserId(User);

            await _staticSiteInfoService.SaveChangesAsync(info);
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public async Task<bool> SetUserRole([FromBody] UserRequestModel model)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(model.UserId);
                if (model.Role == AppUserRoles.Administrator)
                {
                    await _userManager.AddToRoleAsync(user, AppUserRoles.Administrator);
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, AppUserRoles.Administrator);
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}