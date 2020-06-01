using SCManager.ViewModels.Home;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using System.Collections;
using System.Collections.Generic;
using SCManager.Data.Models;

namespace SCManager.ViewModels.Admin
{
    public class AdminTotalViewModel
    {
        public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }

        public IEnumerable<PostListingViewModel> Posts { get; set; }

        public IEnumerable<ComponentTypeListingViewModel> ComponentTypes { get; set; }

        public IEnumerable<UnitMultiplierListingViewModel> UnitMultipliers { get; set; } 
    }
}