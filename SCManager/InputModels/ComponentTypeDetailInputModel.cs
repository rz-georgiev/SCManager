using System.ComponentModel.DataAnnotations;

namespace SCManager.InputModels
{
    public class ComponentTypeDetailInputModel
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Unit { get; set; }

        [Required]
        public string Symbol { get; set; }
    }
}