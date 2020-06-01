using System;

namespace SCManager.Data.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        public string CreatedByUserId { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        public string LastUpdatedByUserId { get; set; }

        public bool IsActive { get; set; } = true;

        public ApplicationUser CreatedByUser { get; set; }

        public ApplicationUser LastUpdatedByUser { get; set; }
    }
}