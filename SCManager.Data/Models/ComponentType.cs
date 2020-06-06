using System.Collections.Generic;

namespace SCManager.Data.Models
{
    public class ComponentType : BaseEntity
    {
        public string Name { get; set; }

        public string ImageId { get; set; }

        public IEnumerable<ComponentTypeDetail> Details { get; set; }
    }
}