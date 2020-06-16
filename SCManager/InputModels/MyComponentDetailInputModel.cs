using System.ComponentModel.DataAnnotations;

namespace SCManager.InputModels
{
    public class MyComponentDetailInputModel
    {
        public int? Id { get; set; }

        [Required]
        public float Value { get; set; }
        
        [Required]
        public int UnitMultiplierId { get; set; }
    }
}