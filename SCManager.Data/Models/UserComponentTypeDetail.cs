namespace SCManager.Data.Models
{
    public class UserComponentTypeDetail : BaseEntity
    {
        public int UserComponentTypeId { get; set; }

        public int ComponentTypeDetailId { get; set; }

        public int UnitMultiplierId { get; set; }

        public UserComponentTypeDetail UserComponentDetail { get; set; }

        public ComponentTypeDetail ComponentDetail { get; set; }

        public UnitMultiplier Multiplier { get; set; }
    }
}