using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class AddNewColumnManualsInAccessories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AssignedDriver",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Sub_Accessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaintenanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Antennae = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AshTray = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackupRearLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CigaretteLighter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoorGlass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoorHandles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emblem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineHood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FloorMats = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GasTankCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadRest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HubCaps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IgnitionSwitch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MudGuards = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NamePlateLight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParkingLights = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadiatorCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RearViewMirror = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SideMirrors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpareTire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StereoSpeakers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SunVisors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tools = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrunkCompartment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Upholstery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WindshieldGlass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WipeArm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WiperKnob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manuals = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_Accessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sub_Accessories_Maintenances_MaintenanceId",
                        column: x => x.MaintenanceId,
                        principalTable: "Maintenances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sub_Accessories_MaintenanceId",
                table: "Sub_Accessories",
                column: "MaintenanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sub_Accessories");

            migrationBuilder.AlterColumn<string>(
                name: "AssignedDriver",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
