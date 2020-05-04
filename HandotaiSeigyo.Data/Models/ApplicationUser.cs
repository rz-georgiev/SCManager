using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandotaiSeigyo.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public IEnumerable<IdentityUserRole<string>> Roles { get; set; }

        public virtual IEnumerable<UserComponentType> UserComponentTypes { get; set; }

    }
}
