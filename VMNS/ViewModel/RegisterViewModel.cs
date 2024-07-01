using VMNS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VMNS.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Employee Number")]
        public int EmpNo { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The Position field has a maximum of 255 characters.")]
        public string Position { get; set; }

        public int? OfficeId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 1)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        // Lookup table
        public virtual lu_Office? Office { get; set; }

    }
}
