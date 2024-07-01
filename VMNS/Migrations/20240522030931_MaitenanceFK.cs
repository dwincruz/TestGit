using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class MaitenanceFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Maintenances_MaintenanceId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_MaintenanceId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MaintenanceId",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Maintenances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "VehicleId1",
                table: "Maintenances",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_VehicleId1",
                table: "Maintenances",
                column: "VehicleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenances_Vehicles_VehicleId1",
                table: "Maintenances",
                column: "VehicleId1",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maintenances_Vehicles_VehicleId1",
                table: "Maintenances");

            migrationBuilder.DropIndex(
                name: "IX_Maintenances_VehicleId1",
                table: "Maintenances");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Maintenances");

            migrationBuilder.DropColumn(
                name: "VehicleId1",
                table: "Maintenances");

            migrationBuilder.AddColumn<Guid>(
                name: "MaintenanceId",
                table: "Vehicles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_MaintenanceId",
                table: "Vehicles",
                column: "MaintenanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Maintenances_MaintenanceId",
                table: "Vehicles",
                column: "MaintenanceId",
                principalTable: "Maintenances",
                principalColumn: "Id");
        }
    }
}
