using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class setDefaultValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Wiring",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UJoints",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TransmissionFluid",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TransmissionAssembly",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TransferCase",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShockAbsorber",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParkingBrakeCable",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NutsAndBolts",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Muffler",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Hoses",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FuelTankVaporVentSystemsHoses",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FluidTankBand",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FluidLinesConnections",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExhaustPipes",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EngineOil",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DustCover",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DriveShaftBoots",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Differential",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Coolant",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConstantVelocityBoots",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CatalyticConverter",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrakeLines",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BallJoints",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AutomaticTransmissionFluid",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Wiring",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WiperBlades",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "WindshieldWiper",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "WindshieldCondition",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TurnSignals",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TailLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Odometer",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlatesLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Indicators",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HornOperation",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HeadLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HazardLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GlassAndMirrors",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FuelTankCapBasket",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FuelGuage",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExteriorLamps",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmergencyBrakeAdjustment",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DashWarningLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClutchOperation",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Carpet",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrakeLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BatteryVoltage",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BackupLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AirConGasket",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AirConFilter",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConditionOfBattery",
                table: "Sub_BatteryPerformances",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BatteryTerminal",
                table: "Sub_BatteryPerformances",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "Not Inspected",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Wiring",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "UJoints",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "TransmissionFluid",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "TransmissionAssembly",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "TransferCase",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "ShockAbsorber",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "ParkingBrakeCable",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "NutsAndBolts",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "Muffler",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "Hoses",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "FuelTankVaporVentSystemsHoses",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "FluidTankBand",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "FluidLinesConnections",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "ExhaustPipes",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "EngineOil",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "DustCover",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "DriveShaftBoots",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "Differential",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "Coolant",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "ConstantVelocityBoots",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "CatalyticConverter",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "BrakeLines",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "BallJoints",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "AutomaticTransmissionFluid",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "Wiring",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "WiperBlades",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "WindshieldWiper",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "WindshieldCondition",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "TurnSignals",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "TailLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "Odometer",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlatesLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "Indicators",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "HornOperation",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "HeadLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "HazardLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "GlassAndMirrors",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "FuelTankCapBasket",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "FuelGuage",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "ExteriorLamps",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "EmergencyBrakeAdjustment",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "DashWarningLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "ClutchOperation",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "Carpet",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "BrakeLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "BatteryVoltage",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "BackupLights",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "AirConGasket",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "AirConFilter",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "ConditionOfBattery",
                table: "Sub_BatteryPerformances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");

            migrationBuilder.AlterColumn<string>(
                name: "BatteryTerminal",
                table: "Sub_BatteryPerformances",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldDefaultValue: "Not Inspected");
        }
    }
}
