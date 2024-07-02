using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VMNS.Models
{
    public class Maintenance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Guid? VehicleId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Date Checked")]
        public DateTime DateChecked { get; set; }

        [Required]
        public int Mileage { get; set; }


        [Required]
        [Display(Name = "Description")]
        [Column(TypeName = "varchar(512)")]
        public string Remarks { get; set; }

        //For Tracking
        public Guid CreatorId { get; set; }
        public Guid? ModifierId { get; set; }
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Date Modified")]
        public DateTime DateModified { get; set; }


        [Display(Name = "Inspector")]
        public string InspectorName { get; set; }


        //Foreign Key
        public virtual Vehicle? Vehicle { get; set; }

    }
}
