using Microsoft.AspNetCore.Http;
using SCManager.CustomAttributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SCManager.InputModels
{
    public class ComponentTypeInputModel
    {
        public int? Id { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxFileSize(5 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".png", ".jpeg", ".jpg", ".gif" })]
        public IFormFile Image { get; set; }

        public IEnumerable<ComponentTypeDetailInputModel> Details { get; set; }

    }
}