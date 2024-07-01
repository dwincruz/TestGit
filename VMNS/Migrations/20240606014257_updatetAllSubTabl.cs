using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class updatetAllSubTabl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplaced",
                table: "Sub_UnderVehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplaced",
                table: "Sub_UnderHoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplaced",
                table: "Sub_InteriorExteriors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplaced",
                table: "Sub_BatteryPerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Sub_BatteryPerformances",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateReplaced",
                table: "Sub_UnderVehicles");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Sub_UnderVehicles");

            migrationBuilder.DropColumn(
                name: "DateReplaced",
                table: "Sub_UnderHoods");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Sub_UnderHoods");

            migrationBuilder.DropColumn(
                name: "DateReplaced",
                table: "Sub_InteriorExteriors");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Sub_InteriorExteriors");

            migrationBuilder.DropColumn(
                name: "DateReplaced",
                table: "Sub_BatteryPerformances");

            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Sub_BatteryPerformances");
        }
    }
}
