using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class Sub_BrakeTires
    {
        [Key]
        public int Id { get; set; }

        public Guid? MaintenanceId { get; set; }

        public int? lu_WheelId { get; set; }

        [Display(Name = "Break Lining")]
        public string BreakLining { get; set; }

        [Display(Name = "Tire Tread")]
        public string TireTread { get; set; }

        [Display(Name = "Wear Pattern")]
        public string WearPattern { get; set; }

        [Display(Name = "Tire Pressure Before")]
        public string TirePressureBefore { get; set; }

        [Display(Name = "Tire Pressure After")]
        public string TirePressureAfter { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Acquired Date")]
        public DateTime AcquisitionDate { get; set; }

        [Display(Name = "Lifespan")]
        public int? LifeSpan { get; set; }

        public string Remarks { get; set; }

        //look up
        [Display(Name = "Fuel Type")]
        public virtual lu_Wheel? lu_Wheel { get; set; }
        public virtual Maintenance? Maintenance { get; set; }
    }
}
