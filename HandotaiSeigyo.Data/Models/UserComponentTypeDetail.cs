namespace HandotaiSeigyo.Data.Models
{
    public class UserComponentTypeDetail : BaseEntity
    {
        public string Value { get; set; }

        public UserComponentType UserComponentType { get; set; }

        public ComponentTypeDetail ComponentTypeDetail { get; set; }

        public UnitMultiplier UnitMultiplier { get; set; }
    }
}