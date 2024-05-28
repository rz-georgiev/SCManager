using Microsoft.AspNetCore.Authorization;
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
        private readonly ISmtpService _sendGridService;

        public RegisterConfirmationModel(UserManager<ApplicationUser> userManager, ISmtpService sendGridService)
        {
            _userManager = userManager;
            _sendGridService = sendGridService;
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