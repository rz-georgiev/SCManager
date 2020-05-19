using SCManager.ViewModels.Home;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using System.Collections;
using System.Collections.Generic;

namespace SCManager.ViewModels.Admin
{
    public class AdminTotalViewModel
    {
        public IEnumerable<PostListingViewModel> Posts { get; set; }

        public IEnumerable<ComponentTypeListingViewModel> ComponentTypes { get; set; }

        public IEnumerable<UnitMultiplierListingViewModel> UnitMultipliers { get; set; } 
    }
}