using VMNS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace VMNS.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.Entity<Sub_UnderHood>()
               .Property(b => b.FluidLevels)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.HeaterHoses)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.AirCondition)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.DriveBelt)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.ComputerBox)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.ElectricFuses)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.Alternator)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.CoolantRecoveryReservoirFluidLevel)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.AirConditionerCondenser)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.CoolingSystemHoses)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.EngineAirFilter)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.ClutchReservoirFluid)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.AuxiliaryBelt)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.Washer)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.RadiatorCore)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.PowerSteering)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.BrakeFluid)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderHood>()
               .Property(b => b.HosesandConnections)
               .HasDefaultValue("Not Inspected");

        //----

        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.AutomaticTransmissionFluid)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.BallJoints)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.BrakeLines)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.CatalyticConverter)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.ConstantVelocityBoots)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.Coolant)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.Differential)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.DriveShaftBoots)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.DustCover)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.EngineOil)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.ExhaustPipes)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.FluidLinesConnections)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.FluidTankBand)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.FuelTankVaporVentSystemsHoses)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.Hoses)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.Muffler)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.NutsAndBolts)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.ParkingBrakeCable)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.ShockAbsorber)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.TransferCase)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.TransmissionAssembly)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.TransmissionFluid)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.UJoints)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_UnderVehicle>()
               .Property(b => b.Wiring)
               .HasDefaultValue("Not Inspected");

        //-----

        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.Carpet)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.AirConGasket)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.AirConFilter)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.BackupLights)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.BatteryVoltage)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.BrakeLights)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.ClutchOperation)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.DashWarningLights)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.EmergencyBrakeAdjustment)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.ExteriorLamps)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.FuelGuage)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.FuelTankCapBasket)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.GlassAndMirrors)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.HazardLights)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.HeadLights)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.HornOperation)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.Indicators)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.LicensePlatesLights)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.Odometer)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.TailLights)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.TurnSignals)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.WindshieldCondition)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.WindshieldWiper)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.WiperBlades)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_InteriorExterior>()
               .Property(b => b.Wiring)
               .HasDefaultValue("Not Inspected");

        //-----

        builder.Entity<Sub_BatteryPerformance>()
               .Property(b => b.BatteryTerminal)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_BatteryPerformance>()
               .Property(b => b.ConditionOfBattery)
               .HasDefaultValue("Not Inspected");

        builder.Entity<Sub_BatteryPerformance>()
               .Property(b => b.BatteryTerminal)
               .HasDefaultValue("Not Inspected");
        builder.Entity<Sub_BatteryPerformance>()
               .Property(b => b.ConditionOfBattery)
               .HasDefaultValue("Not Inspected");

        //-----

        builder.Entity<Sub_Accessories>()
              .Property(b => b.Antennae)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.AshTray)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.BackupRearLights)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.CigaretteLighter)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.DoorGlass)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.DoorHandles)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.Emblem)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.EngineHood)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.FloorMats)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.GasTankCap)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.HeadRest)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.HubCaps)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.IgnitionSwitch)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.Manuals)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.MudGuards)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.NamePlate)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.NamePlateLight)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.ParkingLights)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.RadiatorCap)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.RearViewMirror)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.SideMirrors)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.SpareTire)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.StereoSpeakers)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.SunVisors)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.Tools)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.TrunkCompartment)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.Upholstery)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.WindshieldGlass)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.WipeArm)
              .HasDefaultValue("None");
        builder.Entity<Sub_Accessories>()
              .Property(b => b.WiperKnob)
              .HasDefaultValue("None");

    }

    //Main Tables
    public DbSet<ApplicationRole> ApplicationRole { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<Upload> Uploads { get; set; }
    public DbSet<Maintenance> Maintenances { get; set; }
    public DbSet<VehicleHistory> VehicleHistories { get; set; }
    public DbSet<Replacement> Replacements { get; set; }
    public DbSet<Monitoring> Monitorings { get; set; }
    public DbSet<Accident> Accidents { get; set; }
    public DbSet<Extra> Extras { get; set; }

    //Sub Tables
    public DbSet<Sub_BatteryPerformance> Sub_BatteryPerformances { get; set; }
    public DbSet<Sub_BrakeTires> Sub_BrakeTires { get; set; }
    public DbSet<Sub_InteriorExterior> Sub_InteriorExteriors { get; set; }
    public DbSet<Sub_UnderHood> Sub_UnderHoods { get; set; }
    public DbSet<Sub_UnderVehicle> Sub_UnderVehicles { get; set; }
    public DbSet<Sub_Accessories> Sub_Accessories { get; set; }

    //Lookup Tables
    public DbSet<lu_Office> lu_Offices { get; set; }
    public DbSet<lu_VehicleType> lu_VehicleTypes { get; set; }
    public DbSet<lu_Transmission> lu_Transmissions { get; set; }
    public DbSet<lu_FuelType> lu_FuelTypes { get; set; }
    public DbSet<lu_EquipmentStatus> lu_EquipmentStatus { get; set; }

    public DbSet<lu_Wheel> lu_Wheels { get; set; }
    public DbSet<lu_WheelDrive> lu_WheelDrives { get; set; }
    public DbSet<lu_DamageScale> lu_DamageScales { get; set; }
    public DbSet<lu_VehicleStatus> lu_VehicleStatus { get; set; }


}


public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);

    }
}