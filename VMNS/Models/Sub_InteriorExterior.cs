using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class Sub_InteriorExterior
    {
        [Key]
        public int Id { get; set; }

        public Guid? MaintenanceId { get; set; }

        [Display(Name = "Head Lights")]
        public string HeadLights { get; set; }
        [Display(Name = "Tail Lights")]
        public string TailLights { get; set; }
        [Display(Name = "Turn Signals")]
        public string TurnSignals { get; set; }
        [Display(Name = "Brake Lights")]
        public string BrakeLights { get; set; }
        [Display(Name = "Hazard Lights")]
        public string HazardLights { get; set; }
        [Display(Name = "Exterior Lmaps")]
        public string ExteriorLamps { get; set; }
        [Display(Name = "License Plates Lights")]
        public string LicensePlatesLights { get; set; }
        [Display(Name = "Windshield Wiper")]
        public string WindshieldWiper { get; set; }
        [Display(Name = "Wiper Blades")]
        public string WiperBlades { get; set; }
        [Display(Name = "Windshield Condition")]
        public string WindshieldCondition { get; set; }
        [Display(Name = "Emergency Brake Adjustmnet")]
        public string EmergencyBrakeAdjustment { get; set; }
        [Display(Name = "Horn Operation")]
        public string HornOperation { get; set; }
        [Display(Name = "Fuel Tank Cap Basket")]
        public string FuelTankCapBasket { get; set; }
        [Display(Name = "Aircon Gasket")]
        public string AirConGasket { get; set; }
        [Display(Name = "Aircon Filter")]
        public string AirConFilter { get; set; }
        [Display(Name = "Clutch Operation")]
        public string ClutchOperation { get; set; }
        [Display(Name = "Backup Lights")]
        public string BackupLights { get; set; }
        [Display(Name = "Dash warning lights")]
        public string DashWarningLights { get; set; }
        public string Carpet { get; set; }
        [Display(Name = "Glass and Mirrors")]
        public string GlassAndMirrors{ get; set; }
        public string Wiring { get; set; }

        [Display(Name = "Odometer")]
        public string Odometer { get; set; }
        [Display(Name = "Fuel Guage")]
        public string FuelGuage {  get; set; }
        [Display(Name = "Battery Voltage")]
        public string BatteryVoltage {  get; set; }
        public string Indicators {  get; set; }
        public string Remarks { get; set; }

        //look up
        public virtual Maintenance? Maintenance { get; set; }
    }
}
