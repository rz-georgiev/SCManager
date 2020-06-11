using SCManager.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace SCManager.ViewModels.Home
{
    public class IndexViewModel
    {
        public IEnumerable<UserComponentTypeViewModel> ComponentTypes { get; set; }
    }
}