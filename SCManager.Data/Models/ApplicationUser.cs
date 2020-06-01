namespace SCManager.Data.Models
{
    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser
    {
        public string ImageId { get; set; }
    }
}