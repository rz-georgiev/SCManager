using SCManager.Data.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SCManager.InputModels
{
    public class MyComponentInputModel
    {
        public int? Id { get; set; }

        [Required]
        [DisplayName("Component type")]
        public int ComponentTypeId { get; set; }

        public IEnumerable<ComponentType> ComponentTypes { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public IEnumerable<MyComponentDetailInputModel> Details { get; set; }

        public IEnumerable<UnitMultiplier> UnitMultipliers { get; set; }

    }
}