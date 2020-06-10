using AutoMapper;
using Ganss.XSS;
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
    public class StaticSiteInfoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStaticSiteInfoService _staticSiteInfoService;
        private readonly HtmlSanitizer _htmlSanitizer;
        private readonly UserManager<ApplicationUser> _userManager;

        public StaticSiteInfoController(IMapper mapper,
            IStaticSiteInfoService staticSiteInfoService,
            HtmlSanitizer htmlSanitizer,
            UserManager<ApplicationUser> userManager)
        {
            _mapper = mapper;
            _staticSiteInfoService = staticSiteInfoService;
            _htmlSanitizer = htmlSanitizer;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(int? componentTypeId)
        {
            var info = await _staticSiteInfoService.GetByIdAsync(componentTypeId);
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
        public async Task<IActionResult> Index(StaticSiteInfoInputModel model)
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
    }
}