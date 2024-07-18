using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace VMNS.Models
{
    public class Sub_Accessories
    {
        [Key]
        public int Id { get; set; }

        public Guid? MaintenanceId { get; set; }

        public string? Antennae { get; set; }

        [Display(Name = "Ash Tray")]
        public string? AshTray { get; set; }

        [Display(Name = "Backup Rear Lights")]
        public string? BackupRearLights { get; set; }

        [Display(Name = "Cigarette Lighter")]
        public string? CigaretteLighter { get; set; }

        [Display(Name = "Door Glass")]
        public string? DoorGlass { get; set; }

        [Display(Name = "Door Handles Front & Rear")]
        public string? DoorHandles { get; set; }
        public string? Emblem { get; set; }

        [Display(Name = "Engine Hood")]
        public string? EngineHood { get; set; }

        [Display(Name = "Floor Mats")]
        public string? FloorMats { get; set; }

        [Display(Name = "Gas Tank Cap")]
        public string? GasTankCap { get; set; }

        [Display(Name = "Head Rest")]
        public string? HeadRest { get; set; }

        [Display(Name = "Hub Caps")]
        public string? HubCaps { get; set; }

        [Display(Name = "Ignition Switch")]
        public string? IgnitionSwitch { get; set; }

        [Display(Name = "Mud Guards")]
        public string? MudGuards { get; set; }

        [Display(Name = "Name Plate")]
        public string? NamePlate { get; set; }

        [Display(Name = "Name Plate Light")]
        public string? NamePlateLight { get; set; }

        [Display(Name = "Parking Lights")]
        public string? ParkingLights { get; set; }

        [Display(Name = "Radiator Cap")]
        public string? RadiatorCap { get; set; }

        [Display(Name = "Rear View Mirror")]
        public string? RearViewMirror { get; set; }

        [Display(Name = "Side Mirrors")]
        public string? SideMirrors { get; set; }

        [Display(Name = "Spare Tire & Rim")]
        public string? SpareTire { get; set; }

        [Display(Name = "Stereo Speakers")]
        public string? StereoSpeakers { get; set; }

        [Display(Name = "Sun Visors")]
        public string? SunVisors { get; set; }

        public string? Tools { get; set; }

        [Display(Name = "Trunk Compartment")]
        public string? TrunkCompartment { get; set; }
        public string? Upholstery { get; set; }

        [Display(Name = "Windshield Glass Front & Rear")]
        public string? WindshieldGlass { get; set; }

        [Display(Name = "Wipe Arm & Blade")]
        public string? WipeArm { get; set; }

        [Display(Name = "Wiper Knob")]
        public string? WiperKnob { get; set; }

        [Display(Name = "Manuals")]
        public string? Manuals { get; set; }


        //look up
        public virtual Maintenance? Maintenance { get; set; }
    }
}
