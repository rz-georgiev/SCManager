using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;

namespace SCManager.Data.Models
{
    public class ComponentTypeDetail : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Unit { get; set; }

        [Required]
        public string Symbol { get; set; }

        [Required]
        public int ComponentTypeId { get; set; }

        public ComponentType ComponentType { get; set; }

        [Required]
        public bool IsPrimary { get; set; }
    }
}