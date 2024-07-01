using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class lu_Wheel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Wheel Position")]
        public string WheelPosition { get; set; }
    }
}
