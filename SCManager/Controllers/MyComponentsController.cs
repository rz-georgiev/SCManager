using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.ViewModels.MyComponents;
using System.Collections.Generic;
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

        public MyComponentsController
        (
            UserManager<ApplicationUser> userManager,
            IMapper mapper,
            IComponentTypeService componentTypeService,
            IUnitMultiplierService unitMultiplierService,
            IStaticSiteInfoService staticSiteInfoService,
            IUserComponentTypeService userComponentTypeService
        )
        {
            _userManager = userManager;
            _mapper = mapper;
            _componentTypeService = componentTypeService;
            _unitMultiplierService = unitMultiplierService;
            _staticSiteInfoService = staticSiteInfoService;
            _userComponentTypeService = userComponentTypeService;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var userComponents = _userComponentTypeService.GetAllForUserId(userId);

            var componentModels = new List<ComponentViewModel>();

            componentModels.Add(new ComponentViewModel
            {
                Id = 1,
                Name = "Capacitor",
                Quantity = 5,
                TotalPrice = 250,
                Value = "10 pf"
            });

            var model = new IndexViewModel
            {
                Components = componentModels
            };

            return View(model);
        }
    }
}