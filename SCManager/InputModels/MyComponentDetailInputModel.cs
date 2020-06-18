
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SCManager.InputModels
{
    public class MyComponentDetailInputModel
    {
        public int? DetailId { get; set; }

        public string Name { get; set; }

        [Required]
        public float Value { get; set; }
        
        [Required]
        [DisplayName("Multiplier")]
        public int MultiplierId  { get; set; }

        public string Unit { get; set; }
    }
}