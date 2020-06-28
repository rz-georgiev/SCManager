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

        public AboutController(IStaticSiteInfoService staticSiteInfoService)
        {
            _staticSiteInfoService = staticSiteInfoService;
        }

        public async Task<IActionResult> Index()
        {
            var info = await _staticSiteInfoService.GetByNameAsync("About");
            var model = new IndexViewModel { Content = info?.Content };

            return View(model);
        }
    }
}