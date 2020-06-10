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
    public class UnitMultiplierController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUnitMultiplierService _unitMultiplierService;
        private readonly UserManager<ApplicationUser> _userManager;

        public UnitMultiplierController(IMapper mapper,
            IUnitMultiplierService unitMultiplierService,
            UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _unitMultiplierService = unitMultiplierService;
            _userManager = userManager;
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
    }
}