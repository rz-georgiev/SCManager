﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.InputModels;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize]
    public class StaticSiteInfoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IStaticSiteInfoService _staticSiteInfoService;

        public StaticSiteInfoController(IMapper mapper,
            IStaticSiteInfoService staticSiteInfoService)
        {
            _mapper = mapper;
            _staticSiteInfoService = staticSiteInfoService;
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
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var info = await _staticSiteInfoService.GetByIdAsync(model.Id);

            if (info == null)
            {
                info = new StaticSiteInfo
                {
                    Name = model.Name,
                    Content = model.Content
                };
            }
            else
            {
                info.Name = model.Name;
                info.Content = model.Content;
            }

            await _staticSiteInfoService.SaveChangesAsync(info);

            return RedirectToAction("Index", "Admin");
        }
    }
}