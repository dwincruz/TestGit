using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class Replacement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Parts/Replacement")]
        public string Parts { get; set; }

        [Display(Name = "Duration in KM")]
        public int? DurationInKM { get; set; }

        [Display(Name = "Duration in Days")]
        public int? DurationInDays { get; set; }
    }
}
    