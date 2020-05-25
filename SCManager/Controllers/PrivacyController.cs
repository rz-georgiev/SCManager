using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SCManager.Controllers
{
    [Authorize]
    public class PrivacyController : Controller
    {
        public PrivacyController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}