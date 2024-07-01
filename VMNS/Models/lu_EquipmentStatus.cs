using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class lu_EquipmentStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Equipment Status")]
        public string Name { get; set; }
    }
}
