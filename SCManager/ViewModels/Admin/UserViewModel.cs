using SCManager.Data.Models;
using System;

namespace SCManager.ViewModels.Admin
{
    public class UserViewModel
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public bool IsAdmin { get; set; }
    }
}