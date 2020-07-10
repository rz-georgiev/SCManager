using SCManager.Data.Enums;

namespace SCManager.ViewModels.Search
{
    public class IndexViewModel
    {
        public int Id { get; set; }

        public string ComponentName { get; set; }

        public int? Quantity { get; set; }

        public SearchType SearchType { get; set; }
    }
}