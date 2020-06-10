using SCManager.Data;
using SCManager.Data.Models;
using System.Collections.Generic;

namespace SCManager.ViewModels.Admin
{
    public class IndexViewModel
    {
        public IEnumerable<UserViewModel> Users { get; set; }

        public IEnumerable<ComponentTypeViewModel> ComponentTypes { get; set; }

        public IEnumerable<UnitMultiplierViewModel> UnitMultipliers { get; set; }

        public IEnumerable<StaticSiteInfoViewModel> StaticSiteInfos { get; set; }

    }
}