using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System.ComponentModel;
using System.Threading.Tasks;

namespace SCManager.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly SCManagerDbContext _dbContext;
        private readonly ICloudinaryService _cloudinaryService;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            SCManagerDbContext dbContext,
            ICloudinaryService cloudinaryService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = dbContext;
            _cloudinaryService = cloudinaryService;
        }

        public string ImageUrl { get; set; }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [DisplayName("Image path")]
            public IFormFile FormFile { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var imageUrl = user.ImageUrl;

            Input = new InputModel { };

            Username = userName;
            ImageUrl = $"https://res.cloudinary.com/dffy4iztl/image/upload/v1590249477/{user.ImageUrl}";
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

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            if (Input.FormFile == null)
                return RedirectToPage();

            var url = await _cloudinaryService.UploadImageAsync(Input.FormFile);
            if (string.IsNullOrWhiteSpace(url))
                return RedirectToPage();

            // Deleting old profile image if any
            if (!string.IsNullOrWhiteSpace(user.ImageUrl))
                await _cloudinaryService.DeleteImageAsync(user.ImageUrl);

            // Setting the new profile image
            user.ImageUrl = url;

            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}