namespace HandotaiSeigyo.Data.Models
{
    public class ComponentDetail : BaseEntity
    {
        public int ComponentId { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string Unit { get; set; }

        public Component Component { get; set; }
    }
}