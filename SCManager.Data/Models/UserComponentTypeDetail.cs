namespace SCManager.Data.Models
{
    public class UserComponentTypeDetail : BaseEntity
    {
        public int UserComponentTypeId { get; set; }

        public UserComponentType ComponentType { get; set; }

        public int UnitMultiplierId { get; set; }

        public UnitMultiplier UnitMultiplier { get; set; }
    }
}