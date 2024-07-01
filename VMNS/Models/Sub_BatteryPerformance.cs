using System.ComponentModel.DataAnnotations;

namespace VMNS.Models
{
    public class Sub_BatteryPerformance
    {
        [Key]
        public int Id { get; set; }

        public Guid? MaintenanceId { get; set; }

        public string BatteryTerminal { get; set; }

        public string ConditionOfBattery { get; set; }
        

        public string Remarks { get; set; }

        //look up
        public virtual Maintenance? Maintenance { get; set; }
    }
}
