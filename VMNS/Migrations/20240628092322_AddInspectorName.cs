using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class AddInspectorName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Vehicles",
                type: "varchar(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AddColumn<string>(
                name: "InspectorName",
                table: "Maintenances",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InspectorName",
                table: "Maintenances");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Vehicles",
                type: "varchar(512)",
                maxLength: 512,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(512)",
                oldMaxLength: 512,
                oldNullable: true);
        }
    }
}
