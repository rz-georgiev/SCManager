using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SCManager.Data.Models
{
    public class ComponentType : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public string ImageId { get; set; }

        public IEnumerable<ComponentTypeDetail> Details { get; set; }
    }
}