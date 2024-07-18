using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace VMNS.Models
{
    public class Sub_UnderVehicle
    {
        [Key]
        public int Id { get; set; }

        public Guid? MaintenanceId { get; set; }
        [Display(Name = "Shock Absorber")]
        [DefaultValue("Not Inspected")]
        public string? ShockAbsorber { get; set; }
        public string? Coolant { get; set; }
        public string? Differential { get; set; }
        [Display(Name = "U-Joints")]
        public string? UJoints { get; set; }
        [Display(Name = "Ball Joints")]
        public string? BallJoints { get; set; }
        [Display(Name = "Dust Cover")]
        public string? DustCover { get; set; }
        [Display(Name = "Brake Lines")]
        public string? BrakeLines { get; set; }
        public string? Hoses { get; set; }
        [Display(Name = "Parking Brake Cable")]
        public string? ParkingBrakeCable { get; set; }
        [Display(Name = "Drive Shaft Boots")]
        public string? DriveShaftBoots { get; set; }
        [Display(Name = "Constant Velocity Boots")]
        public string? ConstantVelocityBoots { get; set; }
        public string? Muffler { get; set; }
        [Display(Name = "Exhaust Pipes")]
        public string? ExhaustPipes { get; set; }
        [Display(Name = "Catalytic Converter")]
        public string? CatalyticConverter { get; set; }
        [Display(Name = "Transfer Case")]
        public string? TransferCase { get; set; }
        [Display(Name = "Automatic Transmission Fluid")]
        public string? AutomaticTransmissionFluid { get; set;}
        [Display(Name = "Engine Oil")]
        public string? EngineOil {  get; set; }
        [Display(Name = "Transmission Fluid")]
        public string? TransmissionFluid { get; set; }
        [Display(Name = "Transmission Assembly")]
        public string? TransmissionAssembly { get; set; }
        [Display(Name = "Fluid Lines Connections")]
        public string? FluidLinesConnections { get; set; }
        [Display(Name = "Fluid Tank Band")]
        public string? FluidTankBand { get; set; }
        [Display(Name = "Fuel Tank Vapor Vent System Hoses")]
        public string? FuelTankVaporVentSystemsHoses { get; set;}
        [Display(Name = "Nuts and Bolts")]
        public string? NutsAndBolts {  get; set; }
        public string? Wiring {  get; set; }




        //Additional
        

        public string Remarks { get; set; }

        //look up
        public virtual Maintenance? Maintenance { get; set; }
    }
}
