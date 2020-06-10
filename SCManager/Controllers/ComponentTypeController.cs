using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.InputModels;
using System;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize]
    public class ComponentTypeController : Controller
    {
        private readonly IComponentTypeService _componentTypeService;
        private readonly IMapper _mapper;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly UserManager<ApplicationUser> _userManager;

        public ComponentTypeController(IComponentTypeService componentTypeService,
            IMapper mapper,
            ICloudinaryService cloudinaryService,
            UserManager<ApplicationUser> userManager)
        {
            _componentTypeService = componentTypeService;
            _mapper = mapper;
            _cloudinaryService = cloudinaryService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int? componentTypeId)
        {
            var type = await _componentTypeService.GetByIdAsync(componentTypeId);
            if (type == null)
            {
                return View();
            }
            else
            {
                var model = _mapper.Map<ComponentTypeInputModel>(type);
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Index(ComponentTypeInputModel model)
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

            return RedirectToAction("Index", "Admin");
        }
    }
}