using SCManager.CustomAttributes;
using System.ComponentModel.DataAnnotations;

namespace SCManager.InputModels
{
    public class UnitMultiplierInputModel
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}