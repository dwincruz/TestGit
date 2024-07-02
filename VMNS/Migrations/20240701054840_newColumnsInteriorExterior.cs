using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class newColumnsInteriorExterior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BatteryVoltage",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FuelGuage",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Indicators",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Odometer",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BatteryVoltage",
                table: "Sub_InteriorExteriors");

            migrationBuilder.DropColumn(
                name: "FuelGuage",
                table: "Sub_InteriorExteriors");

            migrationBuilder.DropColumn(
                name: "Indicators",
                table: "Sub_InteriorExteriors");

            migrationBuilder.DropColumn(
                name: "Odometer",
                table: "Sub_InteriorExteriors");
        }
    }
}
