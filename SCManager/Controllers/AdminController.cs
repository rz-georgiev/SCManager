using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using SCManager.ViewModels.Admin;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCManager.Controllers
{
    [Authorize(Roles = UserRights.Administrator)]
    public class AdminController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController
        (
            IMapper mapper,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager
        )
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index()
        {
            var users = _mapper.Map<IEnumerable<UserViewModel>>(_userManager.Users);
            var a = await _userManager.GetUsersInRoleAsync("Administrator");

            var model = new IndexViewModel
            {
                Users = _mapper.Map<IEnumerable<UserViewModel>>(users),
            };

            return View(model);
        }
    }
}