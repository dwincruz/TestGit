using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class lu_WheelDrive
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Wheel Drive")]
        public string WheelDrive { get; set; }
    }
}
