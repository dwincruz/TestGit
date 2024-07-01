using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class UpdateId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sub_BatteryPerformances_Vehicles_VehicleId",
                table: "Sub_BatteryPerformances");

            migrationBuilder.DropForeignKey(
                name: "FK_Sub_BrakeTires_Vehicles_VehicleId",
                table: "Sub_BrakeTires");

            migrationBuilder.DropForeignKey(
                name: "FK_Sub_InteriorExteriors_Vehicles_VehicleId",
                table: "Sub_InteriorExteriors");

            migrationBuilder.DropForeignKey(
                name: "FK_Sub_UnderHoods_Vehicles_VehicleId",
                table: "Sub_UnderHoods");

            migrationBuilder.DropForeignKey(
                name: "FK_Sub_UnderVehicles_Vehicles_VehicleId",
                table: "Sub_UnderVehicles");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Sub_UnderVehicles",
                newName: "MaintenanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Sub_UnderVehicles_VehicleId",
                table: "Sub_UnderVehicles",
                newName: "IX_Sub_UnderVehicles_MaintenanceId");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Sub_UnderHoods",
                newName: "MaintenanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Sub_UnderHoods_VehicleId",
                table: "Sub_UnderHoods",
                newName: "IX_Sub_UnderHoods_MaintenanceId");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Sub_InteriorExteriors",
                newName: "MaintenanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Sub_InteriorExteriors_VehicleId",
                table: "Sub_InteriorExteriors",
                newName: "IX_Sub_InteriorExteriors_MaintenanceId");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Sub_BrakeTires",
                newName: "MaintenanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Sub_BrakeTires_VehicleId",
                table: "Sub_BrakeTires",
                newName: "IX_Sub_BrakeTires_MaintenanceId");

            migrationBuilder.RenameColumn(
                name: "VehicleId",
                table: "Sub_BatteryPerformances",
                newName: "MaintenanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Sub_BatteryPerformances_VehicleId",
                table: "Sub_BatteryPerformances",
                newName: "IX_Sub_BatteryPerformances_MaintenanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sub_BatteryPerformances_Maintenances_MaintenanceId",
                table: "Sub_BatteryPerformances",
                column: "MaintenanceId",
                principalTable: "Maintenances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sub_BrakeTires_Maintenances_MaintenanceId",
                table: "Sub_BrakeTires",
                column: "MaintenanceId",
                principalTable: "Maintenances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sub_InteriorExteriors_Maintenances_MaintenanceId",
                table: "Sub_InteriorExteriors",
                column: "MaintenanceId",
                principalTable: "Maintenances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sub_UnderHoods_Maintenances_MaintenanceId",
                table: "Sub_UnderHoods",
                column: "MaintenanceId",
                principalTable: "Maintenances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sub_UnderVehicles_Maintenances_MaintenanceId",
                table: "Sub_UnderVehicles",
                column: "MaintenanceId",
                principalTable: "Maintenances",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sub_BatteryPerformances_Maintenances_MaintenanceId",
                table: "Sub_BatteryPerformances");

            migrationBuilder.DropForeignKey(
                name: "FK_Sub_BrakeTires_Maintenances_MaintenanceId",
                table: "Sub_BrakeTires");

            migrationBuilder.DropForeignKey(
                name: "FK_Sub_InteriorExteriors_Maintenances_MaintenanceId",
                table: "Sub_InteriorExteriors");

            migrationBuilder.DropForeignKey(
                name: "FK_Sub_UnderHoods_Maintenances_MaintenanceId",
                table: "Sub_UnderHoods");

            migrationBuilder.DropForeignKey(
                name: "FK_Sub_UnderVehicles_Maintenances_MaintenanceId",
                table: "Sub_UnderVehicles");

            migrationBuilder.RenameColumn(
                name: "MaintenanceId",
                table: "Sub_UnderVehicles",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Sub_UnderVehicles_MaintenanceId",
                table: "Sub_UnderVehicles",
                newName: "IX_Sub_UnderVehicles_VehicleId");

            migrationBuilder.RenameColumn(
                name: "MaintenanceId",
                table: "Sub_UnderHoods",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Sub_UnderHoods_MaintenanceId",
                table: "Sub_UnderHoods",
                newName: "IX_Sub_UnderHoods_VehicleId");

            migrationBuilder.RenameColumn(
                name: "MaintenanceId",
                table: "Sub_InteriorExteriors",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Sub_InteriorExteriors_MaintenanceId",
                table: "Sub_InteriorExteriors",
                newName: "IX_Sub_InteriorExteriors_VehicleId");

            migrationBuilder.RenameColumn(
                name: "MaintenanceId",
                table: "Sub_BrakeTires",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Sub_BrakeTires_MaintenanceId",
                table: "Sub_BrakeTires",
                newName: "IX_Sub_BrakeTires_VehicleId");

            migrationBuilder.RenameColumn(
                name: "MaintenanceId",
                table: "Sub_BatteryPerformances",
                newName: "VehicleId");

            migrationBuilder.RenameIndex(
                name: "IX_Sub_BatteryPerformances_MaintenanceId",
                table: "Sub_BatteryPerformances",
                newName: "IX_Sub_BatteryPerformances_VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sub_BatteryPerformances_Vehicles_VehicleId",
                table: "Sub_BatteryPerformances",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sub_BrakeTires_Vehicles_VehicleId",
                table: "Sub_BrakeTires",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sub_InteriorExteriors_Vehicles_VehicleId",
                table: "Sub_InteriorExteriors",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sub_UnderHoods_Vehicles_VehicleId",
                table: "Sub_UnderHoods",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sub_UnderVehicles_Vehicles_VehicleId",
                table: "Sub_UnderVehicles",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");
        }
    }
}
