using System;
using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class Sub_UnderHood
    {
        [Key]
        public int Id { get; set; }

        public Guid? MaintenanceId { get; set; }
        [Display(Name = "Engine Air Filter")]
        public string EngineAirFilter { get; set; }
        [Display(Name = "Brake Fluid")]
        public string BrakeFluid { get; set; }
        [Display(Name = "Auxiliary Belt")]
        public string AuxiliaryBelt { get; set; }
        [Display(Name = "Power Steering")]
        public string PowerSteering { get; set; }
        [Display(Name = "Washer")]
        public string Washer { get; set; }
        [Display(Name = "Drive Belt")]
        public string DriveBelt { get; set; }
        [Display(Name = "Electric Fuses")]
        public string ElectricFuses { get; set; }
        [Display(Name = "Electric Fuses")]
        public string Alternator { get; set; }

        [Display(Name = "Computer Box")]
        public string ComputerBox { get; set; }
        [Display(Name = "Cooling System Hoses")]
        public string CoolingSystemHoses { get; set; }
        [Display(Name = "Heater Hoses")]
        public string HeaterHoses { get; set; }
        [Display(Name = "Air Condtion")]
        public string AirCondition { get; set; }
        [Display(Name = "Air Conditioner Condenser")]
        public string AirConditionerCondenser { get; set; }
        [Display(Name = "Hoses and Connections")]
        public string HosesandConnections { get; set; }
        [Display(Name = "Radiator Core")]
        public string RadiatorCore { get; set; }
        [Display(Name = "Coolant Recovery Reservoir Fluid Level")]
        public string CoolantRecoveryReservoirFluidLevel { get; set; }
        [Display(Name = "Clutch Reservour Fluid")]
        public string ClutchReservoirFluid { get; set; }
        [Display(Name = "Fluid Levels")]
        public string FluidLevels { get; set; }
        [Display(Name = "Remarks")]
        public string Remarks { get; set; }

        //look up
        public virtual Maintenance? Maintenance { get; set; }
    }
}
