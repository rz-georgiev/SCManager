using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SCManager.InputModels
{
    public class StaticSiteInfoInputModel
    {
        public int? Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

    }
}