using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SCManager.ViewModels.Error;

namespace SCManager.Controllers
{
    [AllowAnonymous]
    public class ErrorController : Controller
    {
        public ErrorController()
        {
        }

        [Route("/Error/Index/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            string message = statusCode switch
            {
                404 => "Page Not Found",
                500 => "Internal Server Error",
                _ => "Another page error"
            };

            var model = new IndexViewModel
            {
                ErrorStatusCode = statusCode,
                ErrorStatusMessage = message
            };

            return View(model);
        }
    }
}