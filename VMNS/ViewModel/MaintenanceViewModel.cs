using VMNS.Models;

namespace VMNS.ViewModel
{
    public class MaintenanceViewModel
    {
        public IEnumerable<Maintenance> Maintenance { get; set; }
        public IEnumerable<Sub_BatteryPerformance> Sub_BatteryPerformance { get; set; }
        public IEnumerable<Sub_BrakeTires> Sub_BrakeTires { get; set; }
        public IEnumerable<Sub_InteriorExterior> Sub_InteriorExterior { get; set; }
        public IEnumerable<Sub_UnderHood> Sub_UnderHood { get; set; }
        public IEnumerable<Sub_UnderVehicle> Sub_UnderVehicle { get; set; }
    }
}
