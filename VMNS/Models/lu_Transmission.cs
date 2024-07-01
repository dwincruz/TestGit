using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class lu_Transmission
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Transmission Type")]
        public string TransmissionName { get; set; }
    }
}
