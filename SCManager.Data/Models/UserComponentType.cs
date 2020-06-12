using System.ComponentModel.DataAnnotations.Schema;

namespace SCManager.Data.Models
{
    public class UserComponentType : BaseEntity
    {
        public int ComponentTypeId { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; }

        public float Value { get; set; }

        public ComponentType ComponentType { get; set; }

        public int UnitMultiplierId { get; set; }

        public UnitMultiplier UnitMultiplier { get; set; }
    }
}