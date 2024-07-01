using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class wheel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Wheels",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(128)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Wheels",
                table: "Vehicles",
                type: "varchar(128)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
