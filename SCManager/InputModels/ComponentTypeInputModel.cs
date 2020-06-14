using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SCManager.InputModels
{
    public class ComponentTypeInputModel
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        public IFormFile Image { get; set; }

        public IEnumerable<ComponentTypeDetailInputModel> Details { get; set; }

    }
}