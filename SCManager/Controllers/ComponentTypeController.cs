using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.InputModels;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize]
    public class ComponentTypeController : Controller
    {
        private readonly IComponentTypeService _componentTypeService;
        private readonly IMapper _mapper;
        private readonly ICloudinaryService _cloudinaryService;

        public ComponentTypeController(IComponentTypeService componentTypeService,
            IMapper mapper,
            ICloudinaryService cloudinaryService)
        {
            _componentTypeService = componentTypeService;
            _mapper = mapper;
            _cloudinaryService = cloudinaryService;
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

            if (model.Id == null)
            {
                var type = new ComponentType
                {
                    Name = model.Name,
                    ImageId = newImageId
                };

                await _componentTypeService.SaveChangesAsync(type, true);
            }
            else
            {
                var type = await _componentTypeService.GetByIdAsync(model.Id);
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

                await _componentTypeService.SaveChangesAsync(type, false);
            }

            return RedirectToAction("Index", "Admin");
        }
    }
}