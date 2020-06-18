namespace SCManager.Data.Models
{
    public class UserComponentTypeDetail : BaseEntity
    {
        public string Value { get; set; }

        public int UserComponentTypeId { get; set; }

        public int UnitMultiplierId { get; set; }

        public int ComponentTypeDetailId { get; set; }

        public UserComponentType ComponentType { get; set; }
      
        public UnitMultiplier UnitMultiplier { get; set; }

        public ComponentTypeDetail ComponentTypeDetail { get; set; }
    }
}