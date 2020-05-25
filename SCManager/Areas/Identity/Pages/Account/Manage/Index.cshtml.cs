using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SCManager.Data.Models;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using SCManager.Data;
using Microsoft.AspNetCore.Http;

namespace SCManager.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly Cloudinary _cloudinary;
        private readonly SCManagerDbContext _dbContext;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            Cloudinary cloudinary,
            SCManagerDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _cloudinary = cloudinary;
            _dbContext = dbContext;
        }

    

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        { 
            public IFormFile FormFile { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {

            //var uploadParams = new ImageUploadParams()
            //{
            //    File = new FileDescription(@"C:\Users\RGeorgiev\Desktop\wallpaper.jpg"),  
            //};
            //var uploadResult = await _cloudinary.UploadAsync(uploadParams);
            
            var userName = await _userManager.GetUserNameAsync(user);
            var imageUrl = user.ImageUrl;
            
            Username = userName;

            Input = new InputModel
            {
            };
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
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            //var imageUrl = user.ImageUrl;
            //if (Input.ImageUrl != imageUrl)
            //{
            //    try
            //    {
            //        user.ImageUrl = Input.ImageUrl;
            //        _dbContext.Update(user);

            //        await _dbContext.SaveChangesAsync();
            //    }
            //    catch (Exception ex)
            //    {
            //        StatusMessage = "Unexpected error when trying to set image url.";
            //        return RedirectToPage();
            //    }
            //}

            //await _signInManager.RefreshSignInAsync(user);
            //StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
