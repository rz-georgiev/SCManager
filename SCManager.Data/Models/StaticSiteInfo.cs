using System.ComponentModel.DataAnnotations;

namespace SCManager.Data.Models
{
    public class StaticSiteInfo : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }
    }
}