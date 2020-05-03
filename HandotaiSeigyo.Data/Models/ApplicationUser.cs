using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandotaiSeigyo.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual IEnumerable<UserComponentType> UserComponentTypes { get; set; }

    }
}
