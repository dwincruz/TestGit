using Microsoft.AspNetCore.Identity;
using VMNS.Areas.Identity.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace VMNS.Areas.Identity.Data
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string name) : base(name) { }

        [Required]
        public string Description { get; set; }

        internal static System.Threading.Tasks.Task<dynamic> GetRolesAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
