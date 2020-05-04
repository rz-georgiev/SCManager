using System;
using System.Collections.Generic;
using System.Text;

namespace HandotaiSeigyo.Data.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int CreatedByUserId { get; set; }

        public DateTime? LastUpdatedDateTime { get; set; }

        public int? LastUpdatedByUserId { get; set; }

        public bool IsActive { get; set; }
    }
}
