using System;
using System.Collections.Generic;
using System.Text;
using Scoutter.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Scoutter.Data
{
    // Normally use IdentityUser -> ApplicationUser : IdentityUser has additional member 'user type'
    // Sets columns in our database
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
