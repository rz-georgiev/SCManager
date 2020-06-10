using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
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

        public AdminController
        (
            UserManager<ApplicationUser> userManager,
            IMapper mapper,
            IComponentTypeService componentTypeService,
            IUnitMultiplierService unitMultiplierService,
            IStaticSiteInfoService staticSiteInfoService
        )
        {
            _userManager = userManager;
            _mapper = mapper;
            _componentTypeService = componentTypeService;
            _unitMultiplierService = unitMultiplierService;
            _staticSiteInfoService = staticSiteInfoService;
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
                var imageId = componentTypes.FirstOrDefault(x => x.Id == componentTypeModel.Id)?.ImageId;
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
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }
}