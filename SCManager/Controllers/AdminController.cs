using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.RequestModels;
using SCManager.ViewModels.Admin;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize(Roles = UserRights.Administrator)]
    public class AdminController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IComponentTypeService _componentTypeService;
        private readonly IUnitMultiplierService _unitMultiplierService;

        public AdminController
        (
            IMapper mapper,
            UserManager<ApplicationUser> userManager,
            IComponentTypeService componentTypeService,
            IUnitMultiplierService unitMultiplierService
        )
        {
            _mapper = mapper;
            _userManager = userManager;
            _componentTypeService = componentTypeService;
            _unitMultiplierService = unitMultiplierService;
        }

        public async Task<IActionResult> Index()
        {
            var users = _mapper.Map<IEnumerable<UserViewModel>>(_userManager.Users);
            var administrators = await _userManager.GetUsersInRoleAsync("Administrator");
            var administratorsIds = administrators.Select(x => x.Id).ToList();

            var componentTypes = _componentTypeService.GetAll();
            var componentTypeModels = _mapper.Map<IEnumerable<ComponentTypeViewModel>>(componentTypes);
            var unitMultipliers = _mapper.Map<IEnumerable<UnitMultiplierViewModel>>(_unitMultiplierService.GetAll());

            foreach (var user in users)
                user.IsAdmin = administratorsIds.Contains(user.Id);

            foreach (var componentTypeModel in componentTypeModels)
            {
                var imageId = componentTypes.FirstOrDefault(x => x.Id == componentTypeModel.Id)?.ImageId;
                componentTypeModel.ImageUrl = $"{Constants.BaseImageUrl}{imageId}";
            }

            var model = new IndexViewModel
            {
                Users = users,
                ComponentTypes = componentTypeModels,
                UnitMultipliers = unitMultipliers
            };

            return View(model);
        }
   
        [HttpPost]
        public IActionResult SetUserRole([FromBody] UserRequestModel model)
        {
            return Ok();
        }
    }
}