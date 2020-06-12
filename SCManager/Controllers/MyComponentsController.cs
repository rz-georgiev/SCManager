using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.ViewModels.MyComponents;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public IActionResult Index()
        {
            var userId = _userManager.GetUserId(User);

            var userComponentTypes = _userComponentTypeService.GetAllForUserId(userId)
                .Include(x => x.Details)
                    .ThenInclude(x => x.UnitMultiplier)
                .Include(x => x.ComponentType)
                    .ThenInclude(x => x.Details)
                .ToList();

            var componentModels = new List<ComponentViewModel>();
            userComponentTypes.ForEach(x =>
            {
                var type = x.ComponentType;
                var detail = x.Details.FirstOrDefault();
                var multiplier = detail.UnitMultiplier;
                var typeDetail = type.Details.FirstOrDefault(x => x.IsPrimary);

                componentModels.Add(new ComponentViewModel
                {
                     Id = x.Id,
                     Quantity = x.Quantity,
                     TotalPrice = x.Quantity * x.UnitPrice,
                     Name = type.Name,
                     Value = detail.Value,
                     Unit = $"{multiplier.Name}{typeDetail.Symbol}"
                });
            });

            var model = new IndexViewModel
            {
                Components = componentModels
            };

            return View(model);
        }
    }
}