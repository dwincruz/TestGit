using VMNS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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