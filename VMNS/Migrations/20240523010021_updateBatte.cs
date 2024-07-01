using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class updateBatte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sub_BatteryPerformances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BatteryTerminal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConditionOfBattery = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_BatteryPerformances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sub_BatteryPerformances_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sub_BatteryPerformances_VehicleId",
                table: "Sub_BatteryPerformances",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sub_BatteryPerformances");
        }
    }
}
