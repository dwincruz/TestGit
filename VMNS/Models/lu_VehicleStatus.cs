using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class lu_VehicleStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Vehicle Status")]
        public string VehicleStatus { get; set; }
    }
}
