using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SCManager.CustomAttributes;
using SCManager.Data;
using SCManager.Data.Interfaces;
using SCManager.Data.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        [DisplayName("Profile picture")]
        public string ImageUrl { get; set; }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [DisplayName("New profile picture")]
            [MaxFileSize(5 * 1024 * 1024)]
            [AllowedExtensions(new string[] { ".png", ".jpeg", ".jpg" })]
            public IFormFile FormFile { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var imageId = user.ImageId ?? Constants.DefaultImageId;

            Username = userName;
            ImageUrl = $"{Constants.BaseImageUrl}{imageId}";
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

            var imageId = await _cloudinaryService.UploadImageAsync(Input.FormFile);
            if (string.IsNullOrWhiteSpace(imageId))
                return RedirectToPage();

            // Deleting old profile image if any
            if (!string.IsNullOrWhiteSpace(user.ImageId))
                await _cloudinaryService.DeleteImageAsync(user.ImageId);

            // Setting the new profile image
            user.ImageId = imageId;

            _dbContext.Update(user);
            await _dbContext.SaveChangesAsync();

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}