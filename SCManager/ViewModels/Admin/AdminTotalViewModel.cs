using System.Collections.Generic;

namespace SCManager.ViewModels.Admin
{
    public class AdminTotalViewModel
    {
        public IEnumerable<UserViewModel> Users { get; set; }

        public IEnumerable<PostListingViewModel> Posts { get; set; }

        public IEnumerable<ComponentTypeListingViewModel> ComponentTypes { get; set; }

        public IEnumerable<UnitMultiplierListingViewModel> UnitMultipliers { get; set; }
    }
}