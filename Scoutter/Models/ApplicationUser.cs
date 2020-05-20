using System;
using Microsoft.AspNetCore.Identity;
namespace Scoutter.Models

{
    public class ApplicationUser : IdentityUser
    {
        public string user_type { get; set; }

    }
}