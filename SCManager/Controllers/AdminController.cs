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

namespace SCManager.Controllers
{
    [Authorize(Roles = UserRights.Administrator)]
    public class AdminController : Controller
    {
        private readonly IApplicationUserService _applicationUserService;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController
        (
            IApplicationUserService applicationUserService,
            IMapper mapper,
            UserManager<ApplicationUser> userManager
        )
        {
            _applicationUserService = applicationUserService;
            _mapper = mapper;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var users = _applicationUserService.GetAllApplicationUsers();
            var usersIds = users.Select(x => x.Id).ToList();

            var a = _userManager.Users.ToList();

            var model = new IndexViewModel
            {
                Users = _mapper.Map<IEnumerable<UserViewModel>>(users),
            };

            return View(model);
        }
    }
}