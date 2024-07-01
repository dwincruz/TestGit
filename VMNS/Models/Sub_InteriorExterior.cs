using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class Sub_InteriorExterior
    {
        [Key]
        public int Id { get; set; }

        public Guid? MaintenanceId { get; set; }

        public string HeadLights { get; set; }
        public string TailLights { get; set; }
        public string TurnSignals { get; set; }
        public string BrakeLights { get; set; }
        public string HazardLights { get; set; }
        public string ExteriorLamps { get; set; }
        public string LicensePlatesLights { get; set; }
        public string WindshieldWiper { get; set; }
        public string WiperBlades { get; set; }
        public string WindshieldCondition { get; set; }
        public string EmergencyBrakeAdjustment { get; set; }
        public string HornOperation { get; set; }
        public string FuelTankCapBasket { get; set; }
        public string AirConGasket { get; set; }
        public string AirConFilter { get; set; }
        public string ClutchOperation { get; set; }
        public string BackupLights { get; set; }
        public string DashWarningLights { get; set; }
        public string Carpet { get; set; }
        public string GlassAndMirrors{ get; set; }
        public string Wiring { get; set; }



        public string Remarks { get; set; }

        //look up
        public virtual Maintenance? Maintenance { get; set; }
    }
}
