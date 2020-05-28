﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using SCManager.Data;
using SCManager.Data.Models;
using System.Text;
using System.Threading.Tasks;

namespace SCManager.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterConfirmationModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ISendGridService _emailService;

        public RegisterConfirmationModel(UserManager<ApplicationUser> userManager, ISendGridService emailService)
        {
            _userManager = userManager;
            _emailService = emailService;
        }

        public async Task<IActionResult> OnGetAsync(string receiverEmail, string returnUrl = null)
        {
            if (receiverEmail == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByEmailAsync(receiverEmail);
            if (user == null)
            {
                return NotFound($"Unable to load user with email '{receiverEmail}'.");
            }    

            return Page();
        }
    }
}