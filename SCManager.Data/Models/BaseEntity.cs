using Microsoft.AspNetCore.Identity;
using System;

namespace SCManager.Data.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;

        public DateTime? LastUpdatedDateTime { get; set; }

        public string CreatedByUserId { get; set; }

        public ApplicationUser CreatedByUser { get; set; }

        public string LastUpdatedByUserId { get; set; }

        public ApplicationUser LastUpdatedByUser { get; set; }

        public bool IsActive { get; set; }
    }
}