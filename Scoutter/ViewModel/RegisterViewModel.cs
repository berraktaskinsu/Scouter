using System;
using System.ComponentModel.DataAnnotations;
namespace Scoutter.ViewModel
{
    // RegisterViewModel.cs
    // RegisterView uses this model
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password and confirm password do not match")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "User Type")]
        public string user_type { get; set; }

    }
}
