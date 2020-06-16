using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SCManager.Data.Models
{
    public class UserComponentType : BaseEntity
    {
        public int ComponentTypeId { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; }

        public ComponentType ComponentType { get; set; }

        public IEnumerable<UserComponentTypeDetail> Details { get; set; }

    }
}