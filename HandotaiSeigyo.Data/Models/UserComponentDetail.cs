namespace HandotaiSeigyo.Data.Models
{
    public class UserComponentDetail : BaseEntity
    {
        public int UserComponentId { get; set; }

        public int ComponentDetailId { get; set; }

        public string Value { get; set; }

        public UserComponent UserComponent { get; set; }

        public ComponentDetail ComponentDetail { get; set; }
    }
}