using System;
using Microsoft.AspNetCore.Identity;
namespace Scoutter.Models

{
    // use in ApplicationDbContext instead of IdentityUser
    // We already have built-in IdentityUser (We don't use IdentityUser.cs)
    public class ApplicationUser : IdentityUser
    {
        public string user_type { get; set; }

    }
}