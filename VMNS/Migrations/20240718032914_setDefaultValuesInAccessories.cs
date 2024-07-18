using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class setDefaultValuesInAccessories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WiperKnob",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WipeArm",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WindshieldGlass",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Upholstery",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TrunkCompartment",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Tools",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SunVisors",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "StereoSpeakers",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpareTire",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SideMirrors",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RearViewMirror",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RadiatorCap",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParkingLights",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NamePlateLight",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NamePlate",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MudGuards",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Manuals",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IgnitionSwitch",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HubCaps",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HeadRest",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GasTankCap",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FloorMats",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EngineHood",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Emblem",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoorHandles",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DoorGlass",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CigaretteLighter",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackupRearLights",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AshTray",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Antennae",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "None",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WiperKnob",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "WipeArm",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "WindshieldGlass",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "Upholstery",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "TrunkCompartment",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "Tools",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "SunVisors",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "StereoSpeakers",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "SpareTire",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "SideMirrors",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "RearViewMirror",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "RadiatorCap",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "ParkingLights",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "NamePlateLight",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "NamePlate",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "MudGuards",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "Manuals",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "IgnitionSwitch",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "HubCaps",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "HeadRest",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "GasTankCap",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "FloorMats",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "EngineHood",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "Emblem",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "DoorHandles",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "DoorGlass",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "CigaretteLighter",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "BackupRearLights",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "AshTray",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");

            migrationBuilder.AlterColumn<string>(
                name: "Antennae",
                table: "Sub_Accessories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "None");
        }
    }
}
