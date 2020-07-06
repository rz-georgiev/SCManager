using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SCManager.Data.Models
{
    public class UnitMultiplier : BaseEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
