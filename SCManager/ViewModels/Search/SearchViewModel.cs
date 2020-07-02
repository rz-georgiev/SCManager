using SCManager.Data.Enums;

namespace SCManager.ViewModels.Search
{
    public class SearchViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public SearchType SearchType { get; set; }
    }
}