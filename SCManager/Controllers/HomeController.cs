using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data.Models;
using SCManager.ViewModels;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public HomeController(RoleManager<IdentityRole> manager,
            UserManager<ApplicationUser> userNamager,
            SignInManager<ApplicationUser> signInManager)
        {
            _roleManager = manager;
            _userManager = userNamager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            //var role = new IdentityRole();
            //role.Name = "Administrator";
            //await _roleManager.CreateAsync(role);

            //var appUser = await _userManager.GetUserAsync(User);
            //await _userManager.AddToRoleAsync(appUser, "Administrator");

            

            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}