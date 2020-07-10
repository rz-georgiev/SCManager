using SCManager.Data.Enums;

namespace SCManager.ViewModels.Search
{
    public class ComponentViewModel
    {
        public int Id { get; set; }

        public string ComponentName { get; set; }

        public int? Quantity { get; set; }

        public decimal? TotalPrice { get; set; }

        public string ValueType { get; set; }

        public float? Value { get; set; }

        public string Multiplier { get; set; }

        public string Unit { get; set; }

        public SearchType SearchType { get; set; }
    }
}