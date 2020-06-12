using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.InputModels;
using SCManager.ViewModels.MyComponents;
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

            var componentModels = new List<ComponentViewModel>();
            userComponentTypes.ForEach(x =>
            {
                var type = x.ComponentType;
                var multiplier = x.UnitMultiplier;
                var typeDetail = type.Details.FirstOrDefault(x => x.IsPrimary);

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

            var userComponent = await _userComponentTypeService.GetByIdAsync(userComponentTypeId);
            if (userComponent == null)
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
                //var details = _componentTypeDetailService.GetByComponentTypeId(type.Id);
                //var inputDetails = _mapper.Map<IEnumerable<ComponentTypeDetailInputModel>>(details);

                //var model = _mapper.Map<ComponentTypeInputModel>(type);
                //model.Details = inputDetails;
                return View();
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

            //var newImageId = model.Image != null
            //       ? await _cloudinaryService.UploadImageAsync(model.Image)
            //       : null;

            //var type = await _componentTypeService.GetByIdAsync(model.Id);
            //if (type == null)
            //{
            //    type = new ComponentType
            //    {
            //        Name = model.Name,
            //        ImageId = newImageId,
            //        CreatedDateTime = DateTime.UtcNow,
            //        CreatedByUserId = _userManager.GetUserId(User),
            //        IsActive = true
            //    };
            //}
            //else
            //{
            //    type.Name = model.Name;

            //    if (type.ImageId != null && newImageId != null)
            //    {
            //        await _cloudinaryService.DeleteImageAsync(type.ImageId);
            //        type.ImageId = newImageId;
            //    }
            //    else
            //    {
            //        type.ImageId = newImageId ?? type.ImageId;
            //    }

            //    type.LastUpdatedDateTime = DateTime.UtcNow;
            //    type.LastUpdatedByUserId = _userManager.GetUserId(User);
            //}

            //await _componentTypeService.SaveChangesAsync(type);

            return RedirectToAction("Index", "Admin");
        }

    }
}