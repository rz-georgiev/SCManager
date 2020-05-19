namespace SCManager.Data.Models
{
    public class Post : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImagePath { get; set; }
    }
}