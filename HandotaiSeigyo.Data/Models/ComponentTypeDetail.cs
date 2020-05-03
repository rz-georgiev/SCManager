namespace HandotaiSeigyo.Data.Models
{
    public class ComponentTypeDetail : BaseEntity
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public string Unit { get; set; }

        public ComponentType ComponentType { get; set; }
    }
}