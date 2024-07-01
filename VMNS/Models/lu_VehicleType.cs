using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class lu_VehicleType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Vehicle Type")]
        public string VehicleType { get; set; }
    }
}
