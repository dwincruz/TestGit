using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class testSEtDefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Washer",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RadiatorCore",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PowerSteering",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HosesandConnections",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HeaterHoses",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FluidLevels",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EngineAirFilter",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ElectricFuses",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DriveBelt",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoolingSystemHoses",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoolantRecoveryReservoirFluidLevel",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ComputerBox",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClutchReservoirFluid",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrakeFluid",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AuxiliaryBelt",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Alternator",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AirConditionerCondenser",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AirCondition",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Washer",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "RadiatorCore",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "PowerSteering",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "HosesandConnections",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "HeaterHoses",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "FluidLevels",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "EngineAirFilter",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "ElectricFuses",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "DriveBelt",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "CoolingSystemHoses",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "CoolantRecoveryReservoirFluidLevel",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "ComputerBox",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "ClutchReservoirFluid",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "BrakeFluid",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "AuxiliaryBelt",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "Alternator",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "AirConditionerCondenser",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "AirCondition",
                table: "Sub_UnderHoods",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");
        }
    }
}
