using System.ComponentModel.DataAnnotations;

namespace SCManager.Data.Models
{
    public class UserComponentTypeDetail : BaseEntity
    {
        [Required]
        public float Value { get; set; }

        [Required]
        public int UserComponentTypeId { get; set; }

        [Required]
        public int UnitMultiplierId { get; set; }

        [Required]
        public int ComponentTypeDetailId { get; set; }

        public UserComponentType ComponentType { get; set; }
      
        public UnitMultiplier UnitMultiplier { get; set; }

        public ComponentTypeDetail ComponentTypeDetail { get; set; }
    }
}