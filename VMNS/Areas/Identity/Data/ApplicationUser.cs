using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VMNS.Models;
using Microsoft.AspNetCore.Identity;

namespace VMNS.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Display(Name = "Firstname")]
    public string FirstName { get; set; }

    [Display(Name = "Lastname")]
    public string LastName { get; set; }

    [Display(Name = "Employee Number")]
    public int EmpNo { get; set; }

    [StringLength(255)]
    public string Position { get; set; }

    public int? OfficeId { get; set; }

    public DateTime DateCreated { get; set; }

    // Lookup table
    public virtual lu_Office? Office { get; set; }

}

