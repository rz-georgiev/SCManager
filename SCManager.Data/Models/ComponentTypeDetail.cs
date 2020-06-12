namespace SCManager.Data.Models
{
    public class ComponentTypeDetail : BaseEntity
    {
        public string Name { get; set; }

        public string Unit { get; set; }

        public string Symbol { get; set; }

        public bool IsPrimary { get; set; }

        public ComponentType ComponentType { get; set; }
    }
}