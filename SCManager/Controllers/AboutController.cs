using Ganss.XSS;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data.Interfaces;
using SCManager.ViewModels.About;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize]
    public class AboutController : Controller
    {
        private readonly IStaticSiteInfoService _staticSiteInfoService;
        private readonly HtmlSanitizer _htmlSanitizer;

        public AboutController(IStaticSiteInfoService staticSiteInfoService, HtmlSanitizer htmlSanitizer)
        {
            _staticSiteInfoService = staticSiteInfoService;
            _htmlSanitizer = htmlSanitizer;
        }

        public async Task<IActionResult> Index()
        {
            var info = await _staticSiteInfoService.GetByNameAsync("About");
            var model = new IndexViewModel { Content = info?.Content };

            return View(model);
        }
    }
}