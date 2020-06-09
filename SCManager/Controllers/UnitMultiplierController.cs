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
    public class UnitMultiplierController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitMultiplierService _unitMultiplierService;

        public UnitMultiplierController(IMapper mapper,
            IUnitMultiplierService unitMultiplierService)
        {
            _mapper = mapper;
            _unitMultiplierService = unitMultiplierService;
        }

        public async Task<IActionResult> Index(int? componentTypeId)
        {
            var type = await _unitMultiplierService.GetByIdAsync(componentTypeId);
            if (type == null)
            {
                return View();
            }
            else
            {
                var model = _mapper.Map<UnitMultiplierInputModel>(type);
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Index(UnitMultiplierInputModel model)
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
                    Name = model.Name
                };
            }
            else
            {
                multiplier.Name = model.Name;
            }

            await _unitMultiplierService.SaveChangesAsync(multiplier);

            return RedirectToAction("Index", "Admin");
        }
    }
}