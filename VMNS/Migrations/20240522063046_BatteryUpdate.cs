using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class BatteryUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConditionOfBatteryId",
                table: "BatteryPerformances",
                newName: "ConditionOfBattery");

            migrationBuilder.RenameColumn(
                name: "BatteryTerminalId",
                table: "BatteryPerformances",
                newName: "BatteryTerminal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConditionOfBattery",
                table: "BatteryPerformances",
                newName: "ConditionOfBatteryId");

            migrationBuilder.RenameColumn(
                name: "BatteryTerminal",
                table: "BatteryPerformances",
                newName: "BatteryTerminalId");
        }
    }
}
