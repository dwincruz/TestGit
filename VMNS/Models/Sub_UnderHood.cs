using System;
using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class Sub_UnderHood
    {
        [Key]
        public int Id { get; set; }

        public Guid? MaintenanceId { get; set; }

        public string EngineAirFilter { get; set; }
        public string BrakeFluid { get; set; }
        public string AuxiliaryBelt { get; set; }
        public string PowerSteering { get; set; }
        public string Washer { get; set; }
        public string DriveBelt { get; set; }
        public string ElectricFuses { get; set; }
        public string Alternator { get; set; }
        public string ComputerBox { get; set; }
        public string CoolingSystemHoses { get; set; }
        public string HeaterHoses { get; set; }
        public string AirCondition { get; set; }
        public string AirConditionerCondenser { get; set; }
        public string HosesandConnections { get; set; }
        public string RadiatorCore { get; set; }
        public string CoolantRecoveryReservoirFluidLevel { get; set; }
        public string ClutchReservoirFluid { get; set; }
        public string FluidLevels { get; set; }

        public string Remarks { get; set; }

        //look up
        public virtual Maintenance? Maintenance { get; set; }
    }
}
