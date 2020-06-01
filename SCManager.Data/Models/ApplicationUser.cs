namespace SCManager.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;

    public class ApplicationUser : IdentityUser
    {
        public string ImageId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        public string LastUpdatedByUserId { get; set; }

        public bool IsActive { get; set; }

        public bool IsBanned { get; set; }

        public ApplicationUser CreatedByUser { get; set; }

        public ApplicationUser LastUpdatedByUser { get; set; }
    }
}