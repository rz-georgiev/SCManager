namespace SCManager.Data.Models
{
    public class UserComponentTypeDetail : BaseEntity
    {
        public float Value { get; set; }

        public UserComponentType UserComponentType { get; set; }

        public UnitMultiplier UnitMultiplier { get; set; }
    }
}