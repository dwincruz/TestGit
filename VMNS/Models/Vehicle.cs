using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VMNS.Models
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Brand { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Model { get; set; }

        public int? lu_VehicleTypeId { get; set; }

        public int? lu_TransmissionId { get; set; }


        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Color { get; set; }

        //[Display(Name = "Passenger Seat")]
        //public int PassengerSeat { get; set; }

        //[Required]
        //[Display(Name = "Number of Wheels")]
        //public int Wheels { get; set; }

        public int? lu_FuelTypeId { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        [Display(Name = "Plate Number")]
        public string PlateNo { get; set; }
                
        [Required]
        [Column(TypeName = "varchar(128)")]
        [Display(Name = "Conduction Sticker No")]
        public string ConductionNo { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        [Display(Name = "Insurance Type")]
        public string InsuranceType { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM dd yyyy}")]
        [Display(Name = "Insurance Renewal Date")]
        public DateTime InsuranceDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM dd yyyy}")]
        [Display(Name = "LTO Registration Date")]
        public DateTime LtoRegDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM dd yyyy}")]
        [Display(Name = "LTO Due Date of Renewal")]
        public DateTime LtoDueDate { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        [Display(Name = "Assigned Officer")]
        public string AssignedOfficer { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM dd yyyy}")]
        [Display(Name = "Issued Date")]
        public DateTime IssuedDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM dd yyyy}")]
        [Display(Name = "Aquisition Date")]
        public DateTime AquisitionDate { get; set; }

        [Required]
        [Column(TypeName = "varchar(128)")]
        public string Description { get; set; }

        [MaxLength(512)]
        [Column(TypeName = "varchar(512)")]
        public string? ImagePath { get; set; }

        public int? lu_WheelDriveId { get; set; }


        // New Addition 7.5.24
        public int? lu_VehicleStatusId { get; set; }

        [Display(Name = "EasyTrip RFID")]
        public string EasyTripRFID { get; set; }

        [Display(Name = "Autosweep RFID")]
        public string AutosweepRFID { get; set; }

        [Display(Name = "Vehicle Cost")]
        public string Cost { get; set; }

        [Display(Name = "Assigned Driver")]
        public string AssignedDriver { get; set; }




        public string FullDetail => $"{PlateNo} - {Brand}, {Model}";




        //For Tracking
        public Guid CreatorId { get; set; }
        public Guid? ModifierId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }


        //Lookup Tables
        [Display(Name = "Vehicle Type")]
        public virtual lu_VehicleType? lu_VehicleType { get; set; }
        
        [Display(Name = "Transmission Type")]
        public virtual lu_Transmission? lu_Transmission { get; set; }
        
        [Display(Name = "Fuel Type")]
        public virtual lu_FuelType? lu_FuelType { get; set; }

        [Display(Name = "Wheel Drive")]
        public virtual lu_WheelDrive? lu_WheelDrive { get; set; }

        [Display(Name = "Vehicle leStatus")]
        public virtual lu_VehicleStatus? lu_VehicleStatus { get; set; }

    }
}
