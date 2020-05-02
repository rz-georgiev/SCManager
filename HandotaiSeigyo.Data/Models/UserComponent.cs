using System.ComponentModel.DataAnnotations.Schema;

namespace HandotaiSeigyo.Data.Models
{
    public class UserComponent : BaseEntity
    {
        public int UserId { get; set; }

        public int ComponentId { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        // TODO USERID!!!!!

        public Component Component { get; set; }
    }
}