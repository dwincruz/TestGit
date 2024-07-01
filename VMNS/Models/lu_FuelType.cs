using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class lu_FuelType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        [Display(Name = "Fuel Type")]
        public string FuelName { get; set; }
    }
}
