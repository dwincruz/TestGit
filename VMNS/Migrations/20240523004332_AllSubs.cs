using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class AllSubs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sub_InteriorExteriors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HeadLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TailLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TurnSignals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrakeLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HazardLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExteriorLamps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensePlatesLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WindshieldWiper = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WiperBlades = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WindshieldCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmergencyBrakeAdjustment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HornOperation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuelTankCapBasket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirConGasket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirConFilter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClutchOperation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackupLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DashWarningLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carpet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_InteriorExteriors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sub_InteriorExteriors_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sub_UnderHoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShockAbosrber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SteeringBox = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BallJoints = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Linkage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DustCovers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Muffler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatalyticConverter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnginceOil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrakeLines = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hoses = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParkingBrakeCable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriveShaftBoots = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConstantVelocityBoots = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UJoints = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransmissionLinkage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Differential = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransferCase = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_UnderHoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sub_UnderHoods_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sub_UnderVehicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Oil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coolant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Battery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowerSteering = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrakeFluid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Washer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutomaticTransmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineAirFilter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriveBelts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoolingSystemHoses = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeaterHoses = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirCon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HosesConnections = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadiatorCore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirConCondenser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoolantFluid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClutchFluid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_UnderVehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sub_UnderVehicles_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sub_InteriorExteriors_VehicleId",
                table: "Sub_InteriorExteriors",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sub_UnderHoods_VehicleId",
                table: "Sub_UnderHoods",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sub_UnderVehicles_VehicleId",
                table: "Sub_UnderVehicles",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sub_InteriorExteriors");

            migrationBuilder.DropTable(
                name: "Sub_UnderHoods");

            migrationBuilder.DropTable(
                name: "Sub_UnderVehicles");
        }
    }
}
