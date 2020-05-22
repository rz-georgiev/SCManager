namespace SCManager.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser
    {
        public string ImageUrl { get; set; }
    }
}