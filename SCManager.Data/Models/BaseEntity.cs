using System;
using System.ComponentModel.DataAnnotations;

namespace SCManager.Data.Models
{
    public class BaseEntity
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime CreatedDateTime { get; set; }

        [Required]
        public string CreatedByUserId { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        public string LastUpdatedByUserId { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public ApplicationUser CreatedByUser { get; set; }

        public ApplicationUser LastUpdatedByUser { get; set; }
    }
}