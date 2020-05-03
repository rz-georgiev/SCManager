using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandotaiSeigyo.Data.Models
{
    public class UserComponentType : BaseEntity
    {
        public int ComponentTypeId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public IdentityUser IdentityUser { get; set; }

        public ComponentType ComponentType { get; set; }

        public IEnumerable<UserComponentTypeDetail> Details { get; set; }
    }
}