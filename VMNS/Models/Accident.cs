using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VMNS.Models
{
    public class Accident
    {
        [Key]
        public int Id { get; set; }

        public Guid? VehicleId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Accident Date")]
        public DateTime AccidentDate { get; set; }

        [Required]
        [Column(TypeName = "varchar(512)")]
        public string Damage { get; set; }

        [Required]
        [Column(TypeName = "varchar(512)")]
        public string Remarks { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Repair Date")]
        public DateTime RepairDate { get; set; }

        public int? lu_DamageScaleId { get; set; }

        //For Tracking
        public Guid CreatorId { get; set; }
        public Guid? ModifierId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }


        //Foreign Key
        public virtual Vehicle? Vehicle { get; set; }

        [Display(Name = "Damage Scale")]
        public virtual lu_DamageScale? lu_DamageScale { get; set; }
    }
}
