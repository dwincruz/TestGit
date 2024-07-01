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
        public string ShockAbsorber { get; set; }
        public string Coolant { get; set; }
        public string Differential { get; set; }
        public string UJoints { get; set; }
        public string BallJoints { get; set; }
        public string DustCover { get; set; }
        public string BrakeLines { get; set; }
        public string Hoses{ get; set; }
        public string ParkingBrakeCable { get; set; }
        public string DriveShaftBoots { get; set; }
        public string ConstantVelocityBoots { get; set; }
        public string Muffler { get; set; }
        public string ExhaustPipes { get; set; }
        public string CatalyticConverter { get; set; }
        public string TransferCase { get; set; }
        public string AutomaticTransmissionFluid { get; set;}
        public string EngineOil {  get; set; }
        public string TransmissionFluid{ get; set; }
        public string TransmissionAssembly { get; set; }
        public string FluidLinesConnections { get; set; }
        public string FluidTankBand { get; set; }
        public string FuelTankVaporVentSystemsHoses { get; set;}
        public string NutsAndBolts {  get; set; }
        public string Wiring {  get; set; }




        //Additional
        

        public string Remarks { get; set; }

        //look up
        public virtual Maintenance? Maintenance { get; set; }
    }
}
