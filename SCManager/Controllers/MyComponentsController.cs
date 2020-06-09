using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SCManager.Controllers
{
    [Authorize]
    public class MyComponentsController : Controller
    {
        public MyComponentsController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}