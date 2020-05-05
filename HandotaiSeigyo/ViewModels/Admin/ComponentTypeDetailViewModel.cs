using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandotaiSeigyo.ViewModels.Admin
{
    public class ComponentTypeDetailViewModel
    {
        public ComponentTypeListingViewModel ComponentTypeModel { get; set; }

        public IEnumerable<ComponentTypeDetailListingViewModel> DetailModels { get; set; }
    }
}
