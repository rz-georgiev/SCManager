using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using SCManager.Data;
using System.Text;
using System.Threading.Tasks;

namespace SCManager.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterConfirmationModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSenderService _emailService;

        public RegisterConfirmationModel(UserManager<IdentityUser> userManager, IEmailSenderService emailService)
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

            var userId = await _userManager.GetUserIdAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var EmailConfirmationUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                protocol: Request.Scheme);

            var content = $"Dear {receiverEmail}, <br/>" +
               $"Thank you for registering to SCManager 1.0!.Your registration has been received.<br/>" +
               $"If you would like to activate your account, click on the following link:<br/>" +
               $"<a href='{EmailConfirmationUrl}'>Click here to confirm</a><br/>" +
               $"Have fun using our app!<br/>" +
               $"Best Regards,<br/>" +
               $"SCManager<br/>";


            await _emailService.SendEmailAsync(receiverEmail, "Confirmation link", content);

            return Page();
        }
    }
}