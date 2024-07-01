using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using VMNS.Models;

namespace VMNS.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

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

        [Required]
        [Display(Name = "Office")]
        public int? OfficeId { get; set; }

        // Lookup table
        public virtual lu_Office? Office { get; set; }
        public IEnumerable<SelectListItem> RolesList { get; set; }
    }
}
