using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class AddAssignedDriverToVehicleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "AspNetRoles",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "lu_DamageScales",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DamageScale = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_lu_DamageScales", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "lu_EquipmentStatus",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_lu_EquipmentStatus", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "lu_FuelTypes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        FuelName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_lu_FuelTypes", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "lu_Offices",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        OfficeCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
            //        OfficeName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_lu_Offices", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "lu_Transmissions",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        TransmissionName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_lu_Transmissions", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "lu_VehicleStatus",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleStatus = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_lu_VehicleStatus", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "lu_VehicleTypes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleType = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_lu_VehicleTypes", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "lu_WheelDrives",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        WheelDrive = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_lu_WheelDrives", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "lu_Wheels",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        WheelPosition = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_lu_Wheels", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Replacements",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Parts = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DurationInKM = table.Column<int>(type: "int", nullable: true),
            //        DurationInDays = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Replacements", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Uploads",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ConcernId = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FileName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
            //        FilePath = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: false),
            //        UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Uploads", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoleClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EmpNo = table.Column<int>(type: "int", nullable: false),
            //        Position = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        OfficeId = table.Column<int>(type: "int", nullable: true),
            //        DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
            //        EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
            //        AccessFailedCount = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUsers_lu_Offices_OfficeId",
            //            column: x => x.OfficeId,
            //            principalTable: "lu_Offices",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Vehicles",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Brand = table.Column<string>(type: "varchar(128)", nullable: false),
            //        Model = table.Column<string>(type: "varchar(128)", nullable: false),
            //        lu_VehicleTypeId = table.Column<int>(type: "int", nullable: true),
            //        lu_TransmissionId = table.Column<int>(type: "int", nullable: true),
            //        Color = table.Column<string>(type: "varchar(128)", nullable: false),
            //        lu_FuelTypeId = table.Column<int>(type: "int", nullable: true),
            //        PlateNo = table.Column<string>(type: "varchar(128)", nullable: false),
            //        ConductionNo = table.Column<string>(type: "varchar(128)", nullable: false),
            //        InsuranceType = table.Column<string>(type: "varchar(128)", nullable: false),
            //        InsuranceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        LtoRegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        LtoDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        AssignedOfficer = table.Column<string>(type: "varchar(128)", nullable: false),
            //        AssignedDriver = table.Column<string>(type: "varchar(128)", nullable: false),
            //        IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        AquisitionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Description = table.Column<string>(type: "varchar(128)", nullable: false),
            //        ImagePath = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
            //        lu_WheelDriveId = table.Column<int>(type: "int", nullable: true),
            //        lu_VehicleStatusId = table.Column<int>(type: "int", nullable: true),
            //        EasyTripRFID = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AutosweepRFID = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Cost = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Vehicles", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Vehicles_lu_FuelTypes_lu_FuelTypeId",
            //            column: x => x.lu_FuelTypeId,
            //            principalTable: "lu_FuelTypes",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Vehicles_lu_Transmissions_lu_TransmissionId",
            //            column: x => x.lu_TransmissionId,
            //            principalTable: "lu_Transmissions",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Vehicles_lu_VehicleStatus_lu_VehicleStatusId",
            //            column: x => x.lu_VehicleStatusId,
            //            principalTable: "lu_VehicleStatus",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Vehicles_lu_VehicleTypes_lu_VehicleTypeId",
            //            column: x => x.lu_VehicleTypeId,
            //            principalTable: "lu_VehicleTypes",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Vehicles_lu_WheelDrives_lu_WheelDriveId",
            //            column: x => x.lu_WheelDriveId,
            //            principalTable: "lu_WheelDrives",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserLogins",
            //    columns: table => new
            //    {
            //        LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserRoles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserTokens",
            //    columns: table => new
            //    {
            //        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
            //        Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Accidents",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        AccidentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Damage = table.Column<string>(type: "varchar(512)", nullable: false),
            //        Remarks = table.Column<string>(type: "varchar(512)", nullable: false),
            //        RepairDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        lu_DamageScaleId = table.Column<int>(type: "int", nullable: true),
            //        CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Accidents", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Accidents_lu_DamageScales_lu_DamageScaleId",
            //            column: x => x.lu_DamageScaleId,
            //            principalTable: "lu_DamageScales",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Accidents_Vehicles_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicles",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Extras",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        Tools = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Manuals = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        SpareTires = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Extras", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Extras_Vehicles_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicles",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Maintenances",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        DateChecked = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        Mileage = table.Column<int>(type: "int", nullable: false),
            //        Remarks = table.Column<string>(type: "varchar(512)", nullable: false),
            //        CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        InspectorName = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Maintenances", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Maintenances_Vehicles_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicles",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "VehicleHistories",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ActionDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_VehicleHistories", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_VehicleHistories_Vehicles_VehicleId",
            //            column: x => x.VehicleId,
            //            principalTable: "Vehicles",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Monitorings",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MaintenanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        ReplacementId = table.Column<int>(type: "int", nullable: true),
            //        LifeSpan = table.Column<int>(type: "int", nullable: true),
            //        DistanceLimit = table.Column<int>(type: "int", nullable: true),
            //        CurrentKM = table.Column<int>(type: "int", nullable: true),
            //        DateAcquired = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Monitorings", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Monitorings_Maintenances_MaintenanceId",
            //            column: x => x.MaintenanceId,
            //            principalTable: "Maintenances",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Monitorings_Replacements_ReplacementId",
            //            column: x => x.ReplacementId,
            //            principalTable: "Replacements",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Sub_BatteryPerformances",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MaintenanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        BatteryTerminal = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ConditionOfBattery = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Sub_BatteryPerformances", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Sub_BatteryPerformances_Maintenances_MaintenanceId",
            //            column: x => x.MaintenanceId,
            //            principalTable: "Maintenances",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Sub_BrakeTires",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MaintenanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        lu_WheelId = table.Column<int>(type: "int", nullable: true),
            //        BreakLining = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TireTread = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        WearPattern = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TirePressureBefore = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TirePressureAfter = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AcquisitionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        LifeSpan = table.Column<int>(type: "int", nullable: true),
            //        Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Sub_BrakeTires", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Sub_BrakeTires_lu_Wheels_lu_WheelId",
            //            column: x => x.lu_WheelId,
            //            principalTable: "lu_Wheels",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Sub_BrakeTires_Maintenances_MaintenanceId",
            //            column: x => x.MaintenanceId,
            //            principalTable: "Maintenances",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Sub_InteriorExteriors",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MaintenanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        HeadLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TailLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TurnSignals = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BrakeLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        HazardLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ExteriorLamps = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        LicensePlatesLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        WindshieldWiper = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        WiperBlades = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        WindshieldCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EmergencyBrakeAdjustment = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        HornOperation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FuelTankCapBasket = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AirConGasket = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AirConFilter = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ClutchOperation = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BackupLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DashWarningLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Carpet = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        GlassAndMirrors = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Wiring = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Odometer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FuelGuage = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BatteryVoltage = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Indicators = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Sub_InteriorExteriors", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Sub_InteriorExteriors_Maintenances_MaintenanceId",
            //            column: x => x.MaintenanceId,
            //            principalTable: "Maintenances",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Sub_UnderHoods",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MaintenanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        EngineAirFilter = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BrakeFluid = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AuxiliaryBelt = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        PowerSteering = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Washer = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DriveBelt = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ElectricFuses = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Alternator = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ComputerBox = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CoolingSystemHoses = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        HeaterHoses = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AirCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AirConditionerCondenser = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        HosesandConnections = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        RadiatorCore = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CoolantRecoveryReservoirFluidLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ClutchReservoirFluid = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FluidLevels = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Sub_UnderHoods", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Sub_UnderHoods_Maintenances_MaintenanceId",
            //            column: x => x.MaintenanceId,
            //            principalTable: "Maintenances",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Sub_UnderVehicles",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        MaintenanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
            //        ShockAbsorber = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Coolant = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Differential = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        UJoints = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BallJoints = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DustCover = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        BrakeLines = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Hoses = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ParkingBrakeCable = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DriveShaftBoots = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ConstantVelocityBoots = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Muffler = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        ExhaustPipes = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CatalyticConverter = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TransferCase = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        AutomaticTransmissionFluid = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        EngineOil = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TransmissionFluid = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        TransmissionAssembly = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FluidLinesConnections = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FluidTankBand = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        FuelTankVaporVentSystemsHoses = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        NutsAndBolts = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Wiring = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Sub_UnderVehicles", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Sub_UnderVehicles_Maintenances_MaintenanceId",
            //            column: x => x.MaintenanceId,
            //            principalTable: "Maintenances",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Accidents_lu_DamageScaleId",
            //    table: "Accidents",
            //    column: "lu_DamageScaleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Accidents_VehicleId",
            //    table: "Accidents",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetRoleClaims_RoleId",
            //    table: "AspNetRoleClaims",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "RoleNameIndex",
            //    table: "AspNetRoles",
            //    column: "NormalizedName",
            //    unique: true,
            //    filter: "[NormalizedName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserClaims_UserId",
            //    table: "AspNetUserClaims",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserLogins_UserId",
            //    table: "AspNetUserLogins",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUserRoles_RoleId",
            //    table: "AspNetUserRoles",
            //    column: "RoleId");

            //migrationBuilder.CreateIndex(
            //    name: "EmailIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedEmail");

            //migrationBuilder.CreateIndex(
            //    name: "IX_AspNetUsers_OfficeId",
            //    table: "AspNetUsers",
            //    column: "OfficeId");

            //migrationBuilder.CreateIndex(
            //    name: "UserNameIndex",
            //    table: "AspNetUsers",
            //    column: "NormalizedUserName",
            //    unique: true,
            //    filter: "[NormalizedUserName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Extras_VehicleId",
            //    table: "Extras",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Maintenances_VehicleId",
            //    table: "Maintenances",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Monitorings_MaintenanceId",
            //    table: "Monitorings",
            //    column: "MaintenanceId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Monitorings_ReplacementId",
            //    table: "Monitorings",
            //    column: "ReplacementId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Sub_BatteryPerformances_MaintenanceId",
            //    table: "Sub_BatteryPerformances",
            //    column: "MaintenanceId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Sub_BrakeTires_lu_WheelId",
            //    table: "Sub_BrakeTires",
            //    column: "lu_WheelId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Sub_BrakeTires_MaintenanceId",
            //    table: "Sub_BrakeTires",
            //    column: "MaintenanceId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Sub_InteriorExteriors_MaintenanceId",
            //    table: "Sub_InteriorExteriors",
            //    column: "MaintenanceId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Sub_UnderHoods_MaintenanceId",
            //    table: "Sub_UnderHoods",
            //    column: "MaintenanceId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Sub_UnderVehicles_MaintenanceId",
            //    table: "Sub_UnderVehicles",
            //    column: "MaintenanceId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_VehicleHistories_VehicleId",
            //    table: "VehicleHistories",
            //    column: "VehicleId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vehicles_lu_FuelTypeId",
            //    table: "Vehicles",
            //    column: "lu_FuelTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vehicles_lu_TransmissionId",
            //    table: "Vehicles",
            //    column: "lu_TransmissionId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vehicles_lu_VehicleStatusId",
            //    table: "Vehicles",
            //    column: "lu_VehicleStatusId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vehicles_lu_VehicleTypeId",
            //    table: "Vehicles",
            //    column: "lu_VehicleTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Vehicles_lu_WheelDriveId",
            //    table: "Vehicles",
            //    column: "lu_WheelDriveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Accidents");

            //migrationBuilder.DropTable(
            //    name: "AspNetRoleClaims");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserClaims");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserLogins");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserRoles");

            //migrationBuilder.DropTable(
            //    name: "AspNetUserTokens");

            //migrationBuilder.DropTable(
            //    name: "Extras");

            //migrationBuilder.DropTable(
            //    name: "lu_EquipmentStatus");

            //migrationBuilder.DropTable(
            //    name: "Monitorings");

            //migrationBuilder.DropTable(
            //    name: "Sub_BatteryPerformances");

            //migrationBuilder.DropTable(
            //    name: "Sub_BrakeTires");

            //migrationBuilder.DropTable(
            //    name: "Sub_InteriorExteriors");

            //migrationBuilder.DropTable(
            //    name: "Sub_UnderHoods");

            //migrationBuilder.DropTable(
            //    name: "Sub_UnderVehicles");

            //migrationBuilder.DropTable(
            //    name: "Uploads");

            //migrationBuilder.DropTable(
            //    name: "VehicleHistories");

            //migrationBuilder.DropTable(
            //    name: "lu_DamageScales");

            //migrationBuilder.DropTable(
            //    name: "AspNetRoles");

            //migrationBuilder.DropTable(
            //    name: "AspNetUsers");

            //migrationBuilder.DropTable(
            //    name: "Replacements");

            //migrationBuilder.DropTable(
            //    name: "lu_Wheels");

            //migrationBuilder.DropTable(
            //    name: "Maintenances");

            //migrationBuilder.DropTable(
            //    name: "lu_Offices");

            //migrationBuilder.DropTable(
            //    name: "Vehicles");

            //migrationBuilder.DropTable(
            //    name: "lu_FuelTypes");

            //migrationBuilder.DropTable(
            //    name: "lu_Transmissions");

            //migrationBuilder.DropTable(
            //    name: "lu_VehicleStatus");

            //migrationBuilder.DropTable(
            //    name: "lu_VehicleTypes");

            //migrationBuilder.DropTable(
            //    name: "lu_WheelDrives");
        }
    }
}
