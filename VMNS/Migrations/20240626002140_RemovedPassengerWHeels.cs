using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class RemovedPassengerWHeels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PassengerSeat",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Wheels",
                table: "Vehicles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PassengerSeat",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wheels",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
