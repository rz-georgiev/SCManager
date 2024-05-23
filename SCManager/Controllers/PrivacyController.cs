using Ganss.Xss;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data.Interfaces;
using SCManager.ViewModels.Privacy;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [AllowAnonymous]
    public class PrivacyController : Controller
    {
        private readonly IStaticSiteInfoService _staticSiteInfoService;
        private readonly HtmlSanitizer _htmlSanitizer;

        public PrivacyController(IStaticSiteInfoService staticSiteInfoService, HtmlSanitizer htmlSanitizer)
        {
            _staticSiteInfoService = staticSiteInfoService;
            _htmlSanitizer = htmlSanitizer;
        }

        public async Task<IActionResult> Index()
        {
            var info = await _staticSiteInfoService.GetByNameAsync("Privacy");
            var model = new IndexViewModel { Content = info?.Content };

            return View(model);
        }
    }
}