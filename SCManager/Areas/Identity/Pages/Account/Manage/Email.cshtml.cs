using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using SCManager.Data;
using SCManager.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace SCManager.Areas.Identity.Pages.Account.Manage
{
    public partial class EmailModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ISmtpService _sendGridService;

        public EmailModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ISmtpService sendGridService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _sendGridService = sendGridService;
        }

        public string Username { get; set; }

        public string Email { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "New email")]
            public string NewEmail { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var email = await _userManager.GetEmailAsync(user);
            Email = email;

            Input = new InputModel
            {
                NewEmail = email,
            };

            IsEmailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostChangeEmailAsync()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(currentUser);
                return Page();
            }

            var email = await _userManager.GetEmailAsync(currentUser);
            if (Input.NewEmail != email)
            {
                if (await IsEmailUsedByAnotherUserAsync(Input.NewEmail, currentUser))
                {
                    StatusMessage = "Email is used by another user.";
                    return RedirectToPage();
                }

                var userId = await _userManager.GetUserIdAsync(currentUser);
                var code = await _userManager.GenerateChangeEmailTokenAsync(currentUser, Input.NewEmail);
                var callbackUrl = Url.Page(
                    "/Account/ConfirmEmailChange",
                    pageHandler: null,
                    values: new { userId = userId, email = Input.NewEmail, code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code)) },
                    protocol: Request.Scheme);

                var message = $"We are sending you a account confirmation link.<br/>" +
                              $"<a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>Click here to confirm</a><br/>";

                await _sendGridService.SendEmailAsync(Input.NewEmail, "Email change", message);

                StatusMessage = "Confirmation link for email changing was sent. Please check your email.";
                return RedirectToPage();
            }

            StatusMessage = "Your email is unchanged.";
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var userId = await _userManager.GetUserIdAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user); 
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var callbackUrl = Url.Page(
                "/Account/ConfirmEmail",
                pageHandler: null,
                values: new { area = "Identity", userId = userId, code = code },
                protocol: Request.Scheme);

            var message = $"Confirm your email.<br/>" +
                          $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>Clicking here</a>.";

            await _sendGridService.SendEmailAsync(email, "Confirmation link", message);

            StatusMessage = "Verification email sent. Please check your email.";
            return RedirectToPage();
        }

        private async Task<bool> IsEmailUsedByAnotherUserAsync(string email, ApplicationUser user)
        {
            var emailInUse = await _userManager.Users.AnyAsync
            (
                x =>
                x.Email == Input.NewEmail &&
                x.Id != user.Id
            );

            return emailInUse;
        }
    }
}