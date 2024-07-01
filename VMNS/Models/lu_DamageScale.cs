using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class lu_DamageScale
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Damage Scale")]
        public string DamageScale { get; set; }
    }
}
