using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class ModifiedFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Washer",
                table: "Sub_UnderVehicles",
                newName: "Wiring");

            migrationBuilder.RenameColumn(
                name: "RadiatorCore",
                table: "Sub_UnderVehicles",
                newName: "UJoints");

            migrationBuilder.RenameColumn(
                name: "PowerSteering",
                table: "Sub_UnderVehicles",
                newName: "TrasnferCase");

            migrationBuilder.RenameColumn(
                name: "Oil",
                table: "Sub_UnderVehicles",
                newName: "TransmissionFluid");

            migrationBuilder.RenameColumn(
                name: "HosesConnections",
                table: "Sub_UnderVehicles",
                newName: "TransmissionAssembly");

            migrationBuilder.RenameColumn(
                name: "HeaterHoses",
                table: "Sub_UnderVehicles",
                newName: "ShockAbsorber");

            migrationBuilder.RenameColumn(
                name: "EngineAirFilter",
                table: "Sub_UnderVehicles",
                newName: "ParkingBrakeCable");

            migrationBuilder.RenameColumn(
                name: "DriveBelts",
                table: "Sub_UnderVehicles",
                newName: "NutsAndBolts");

            migrationBuilder.RenameColumn(
                name: "CoolingSystemHoses",
                table: "Sub_UnderVehicles",
                newName: "Muffler");

            migrationBuilder.RenameColumn(
                name: "CoolantFluid",
                table: "Sub_UnderVehicles",
                newName: "Hoses");

            migrationBuilder.RenameColumn(
                name: "ClutchFluid",
                table: "Sub_UnderVehicles",
                newName: "FuelTankVaporVentSystemsHoses");

            migrationBuilder.RenameColumn(
                name: "BrakeFluid",
                table: "Sub_UnderVehicles",
                newName: "FluidLinesConnections");

            migrationBuilder.RenameColumn(
                name: "Battery",
                table: "Sub_UnderVehicles",
                newName: "ExhaustPipes");

            migrationBuilder.RenameColumn(
                name: "AutomaticTransmission",
                table: "Sub_UnderVehicles",
                newName: "EngineOil");

            migrationBuilder.RenameColumn(
                name: "AirConCondenser",
                table: "Sub_UnderVehicles",
                newName: "DustCover");

            migrationBuilder.RenameColumn(
                name: "AirCon",
                table: "Sub_UnderVehicles",
                newName: "DriveShaftBoots");

            migrationBuilder.RenameColumn(
                name: "UJoints",
                table: "Sub_UnderHoods",
                newName: "Washer");

            migrationBuilder.RenameColumn(
                name: "TransmissionLinkage",
                table: "Sub_UnderHoods",
                newName: "RadiatorCore");

            migrationBuilder.RenameColumn(
                name: "Transmission",
                table: "Sub_UnderHoods",
                newName: "PowerSteering");

            migrationBuilder.RenameColumn(
                name: "TransferCase",
                table: "Sub_UnderHoods",
                newName: "HosesandConnections");

            migrationBuilder.RenameColumn(
                name: "SteeringBox",
                table: "Sub_UnderHoods",
                newName: "HeaterHoses");

            migrationBuilder.RenameColumn(
                name: "ShockAbosrber",
                table: "Sub_UnderHoods",
                newName: "FluidLevels");

            migrationBuilder.RenameColumn(
                name: "ParkingBrakeCable",
                table: "Sub_UnderHoods",
                newName: "EngineAirFilter");

            migrationBuilder.RenameColumn(
                name: "Muffler",
                table: "Sub_UnderHoods",
                newName: "ElectricFuses");

            migrationBuilder.RenameColumn(
                name: "Linkage",
                table: "Sub_UnderHoods",
                newName: "DriveBelt");

            migrationBuilder.RenameColumn(
                name: "Hoses",
                table: "Sub_UnderHoods",
                newName: "CoolingSystemHoses");

            migrationBuilder.RenameColumn(
                name: "EnginceOil",
                table: "Sub_UnderHoods",
                newName: "CoolantRecoveryReservoirFluidLevel");

            migrationBuilder.RenameColumn(
                name: "DustCovers",
                table: "Sub_UnderHoods",
                newName: "ComputerBox");

            migrationBuilder.RenameColumn(
                name: "DriveShaftBoots",
                table: "Sub_UnderHoods",
                newName: "ClutchReservoirFluid");

            migrationBuilder.RenameColumn(
                name: "Differential",
                table: "Sub_UnderHoods",
                newName: "BrakeFluid");

            migrationBuilder.RenameColumn(
                name: "ConstantVelocityBoots",
                table: "Sub_UnderHoods",
                newName: "AuxiliaryBelt");

            migrationBuilder.RenameColumn(
                name: "CatalyticConverter",
                table: "Sub_UnderHoods",
                newName: "Alternator");

            migrationBuilder.RenameColumn(
                name: "BrakeLines",
                table: "Sub_UnderHoods",
                newName: "AirConditionerCondenser");

            migrationBuilder.RenameColumn(
                name: "BallJoints",
                table: "Sub_UnderHoods",
                newName: "AirCondition");

            migrationBuilder.AddColumn<string>(
                name: "WheelDrive",
                table: "Vehicles",
                type: "varchar(128)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AutomaticTransmissionFluid",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BallJoints",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BrakeLines",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CatalyticConverter",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ConstantVelocityBoots",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Diffential",
                table: "Sub_UnderVehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GlassAndMirrors",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Wiring",
                table: "Sub_InteriorExteriors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DamageScale",
                table: "Accidents",
                type: "varchar(128)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WheelDrive",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "AutomaticTransmissionFluid",
                table: "Sub_UnderVehicles");

            migrationBuilder.DropColumn(
                name: "BallJoints",
                table: "Sub_UnderVehicles");

            migrationBuilder.DropColumn(
                name: "BrakeLines",
                table: "Sub_UnderVehicles");

            migrationBuilder.DropColumn(
                name: "CatalyticConverter",
                table: "Sub_UnderVehicles");

            migrationBuilder.DropColumn(
                name: "ConstantVelocityBoots",
                table: "Sub_UnderVehicles");

            migrationBuilder.DropColumn(
                name: "Diffential",
                table: "Sub_UnderVehicles");

            migrationBuilder.DropColumn(
                name: "GlassAndMirrors",
                table: "Sub_InteriorExteriors");

            migrationBuilder.DropColumn(
                name: "Wiring",
                table: "Sub_InteriorExteriors");

            migrationBuilder.DropColumn(
                name: "DamageScale",
                table: "Accidents");

            migrationBuilder.RenameColumn(
                name: "Wiring",
                table: "Sub_UnderVehicles",
                newName: "Washer");

            migrationBuilder.RenameColumn(
                name: "UJoints",
                table: "Sub_UnderVehicles",
                newName: "RadiatorCore");

            migrationBuilder.RenameColumn(
                name: "TrasnferCase",
                table: "Sub_UnderVehicles",
                newName: "PowerSteering");

            migrationBuilder.RenameColumn(
                name: "TransmissionFluid",
                table: "Sub_UnderVehicles",
                newName: "Oil");

            migrationBuilder.RenameColumn(
                name: "TransmissionAssembly",
                table: "Sub_UnderVehicles",
                newName: "HosesConnections");

            migrationBuilder.RenameColumn(
                name: "ShockAbsorber",
                table: "Sub_UnderVehicles",
                newName: "HeaterHoses");

            migrationBuilder.RenameColumn(
                name: "ParkingBrakeCable",
                table: "Sub_UnderVehicles",
                newName: "EngineAirFilter");

            migrationBuilder.RenameColumn(
                name: "NutsAndBolts",
                table: "Sub_UnderVehicles",
                newName: "DriveBelts");

            migrationBuilder.RenameColumn(
                name: "Muffler",
                table: "Sub_UnderVehicles",
                newName: "CoolingSystemHoses");

            migrationBuilder.RenameColumn(
                name: "Hoses",
                table: "Sub_UnderVehicles",
                newName: "CoolantFluid");

            migrationBuilder.RenameColumn(
                name: "FuelTankVaporVentSystemsHoses",
                table: "Sub_UnderVehicles",
                newName: "ClutchFluid");

            migrationBuilder.RenameColumn(
                name: "FluidLinesConnections",
                table: "Sub_UnderVehicles",
                newName: "BrakeFluid");

            migrationBuilder.RenameColumn(
                name: "ExhaustPipes",
                table: "Sub_UnderVehicles",
                newName: "Battery");

            migrationBuilder.RenameColumn(
                name: "EngineOil",
                table: "Sub_UnderVehicles",
                newName: "AutomaticTransmission");

            migrationBuilder.RenameColumn(
                name: "DustCover",
                table: "Sub_UnderVehicles",
                newName: "AirConCondenser");

            migrationBuilder.RenameColumn(
                name: "DriveShaftBoots",
                table: "Sub_UnderVehicles",
                newName: "AirCon");

            migrationBuilder.RenameColumn(
                name: "Washer",
                table: "Sub_UnderHoods",
                newName: "UJoints");

            migrationBuilder.RenameColumn(
                name: "RadiatorCore",
                table: "Sub_UnderHoods",
                newName: "TransmissionLinkage");

            migrationBuilder.RenameColumn(
                name: "PowerSteering",
                table: "Sub_UnderHoods",
                newName: "Transmission");

            migrationBuilder.RenameColumn(
                name: "HosesandConnections",
                table: "Sub_UnderHoods",
                newName: "TransferCase");

            migrationBuilder.RenameColumn(
                name: "HeaterHoses",
                table: "Sub_UnderHoods",
                newName: "SteeringBox");

            migrationBuilder.RenameColumn(
                name: "FluidLevels",
                table: "Sub_UnderHoods",
                newName: "ShockAbosrber");

            migrationBuilder.RenameColumn(
                name: "EngineAirFilter",
                table: "Sub_UnderHoods",
                newName: "ParkingBrakeCable");

            migrationBuilder.RenameColumn(
                name: "ElectricFuses",
                table: "Sub_UnderHoods",
                newName: "Muffler");

            migrationBuilder.RenameColumn(
                name: "DriveBelt",
                table: "Sub_UnderHoods",
                newName: "Linkage");

            migrationBuilder.RenameColumn(
                name: "CoolingSystemHoses",
                table: "Sub_UnderHoods",
                newName: "Hoses");

            migrationBuilder.RenameColumn(
                name: "CoolantRecoveryReservoirFluidLevel",
                table: "Sub_UnderHoods",
                newName: "EnginceOil");

            migrationBuilder.RenameColumn(
                name: "ComputerBox",
                table: "Sub_UnderHoods",
                newName: "DustCovers");

            migrationBuilder.RenameColumn(
                name: "ClutchReservoirFluid",
                table: "Sub_UnderHoods",
                newName: "DriveShaftBoots");

            migrationBuilder.RenameColumn(
                name: "BrakeFluid",
                table: "Sub_UnderHoods",
                newName: "Differential");

            migrationBuilder.RenameColumn(
                name: "AuxiliaryBelt",
                table: "Sub_UnderHoods",
                newName: "ConstantVelocityBoots");

            migrationBuilder.RenameColumn(
                name: "Alternator",
                table: "Sub_UnderHoods",
                newName: "CatalyticConverter");

            migrationBuilder.RenameColumn(
                name: "AirConditionerCondenser",
                table: "Sub_UnderHoods",
                newName: "BrakeLines");

            migrationBuilder.RenameColumn(
                name: "AirCondition",
                table: "Sub_UnderHoods",
                newName: "BallJoints");
        }
    }
}
