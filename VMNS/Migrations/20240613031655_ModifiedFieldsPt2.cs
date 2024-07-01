using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class ModifiedFieldsPt2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateReplaced",
                table: "Sub_UnderVehicles");

            migrationBuilder.DropColumn(
                name: "DateReplaced",
                table: "Sub_UnderHoods");

            migrationBuilder.DropColumn(
                name: "DateReplaced",
                table: "Sub_InteriorExteriors");

            migrationBuilder.DropColumn(
                name: "DateReplaced",
                table: "Sub_BrakeTires");

            migrationBuilder.DropColumn(
                name: "DateReplaced",
                table: "Sub_BatteryPerformances");

            migrationBuilder.DropColumn(
                name: "DateReplaced",
                table: "Monitorings");

            migrationBuilder.RenameColumn(
                name: "CurrentDays",
                table: "Monitorings",
                newName: "Lifespan");

            migrationBuilder.AddColumn<int>(
                name: "DistanceLimit",
                table: "Monitorings",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistanceLimit",
                table: "Monitorings");

            migrationBuilder.RenameColumn(
                name: "Lifespan",
                table: "Monitorings",
                newName: "CurrentDays");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplaced",
                table: "Sub_UnderVehicles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplaced",
                table: "Sub_UnderHoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplaced",
                table: "Sub_InteriorExteriors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplaced",
                table: "Sub_BrakeTires",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplaced",
                table: "Sub_BatteryPerformances",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplaced",
                table: "Monitorings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
