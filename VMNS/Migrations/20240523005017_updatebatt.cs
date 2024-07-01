using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class updatebatt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "VehicleId",
                table: "BatteryPerformances",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BatteryPerformances_VehicleId",
                table: "BatteryPerformances",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BatteryPerformances_Vehicles_VehicleId",
                table: "BatteryPerformances",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BatteryPerformances_Vehicles_VehicleId",
                table: "BatteryPerformances");

            migrationBuilder.DropIndex(
                name: "IX_BatteryPerformances_VehicleId",
                table: "BatteryPerformances");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "BatteryPerformances");
        }
    }
}
