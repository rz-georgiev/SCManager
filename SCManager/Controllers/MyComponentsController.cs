using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data.Interfaces;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize]
    public class MyComponentsController : Controller
    {
        private readonly IStaticSiteInfoService _staticSiteInfoService;

        public MyComponentsController()
        {
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}