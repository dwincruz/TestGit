using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class ModifiedFieldsPt4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WheelDrive",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "lu_DriveId",
                table: "Vehicles",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lu_DriveId",
                table: "Vehicles");

            migrationBuilder.AddColumn<string>(
                name: "WheelDrive",
                table: "Vehicles",
                type: "varchar(128)",
                nullable: false,
                defaultValue: "");
        }
    }
}
