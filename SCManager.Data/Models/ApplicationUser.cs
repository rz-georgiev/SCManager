namespace SCManager.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ApplicationUser : IdentityUser
    {
        public string ImageId { get; set; }

        [Required]
        public DateTime CreatedDateTime { get; set; }
        
        public DateTime? LastUpdatedDateTime { get; set; }

        public string LastUpdatedByUserId { get; set; }

        [Required]
        public bool IsBanned { get; set; }

        public ApplicationUser LastUpdatedByUser { get; set; }
    }
}