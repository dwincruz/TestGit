using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class lu_Office
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(6)]
        [Display(Name = "Office Code")]
        public string OfficeCode { get; set; }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Office Name")]
        public string OfficeName { get; set; }
    }
}
