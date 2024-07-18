using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class addRemarksInAccessories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RadiatorCore",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "AirCondition",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "WiperBlades",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "WindshieldWiper",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "TailLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "HeadLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "BrakeLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AddColumn<string>(
                name: "Remarks",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remarks",
                table: "Sub_Accessories");

            migrationBuilder.AlterColumn<string>(
                name: "RadiatorCore",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "AirCondition",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "WiperBlades",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "WindshieldWiper",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "TailLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "HeadLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "BrakeLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");
        }
    }
}
