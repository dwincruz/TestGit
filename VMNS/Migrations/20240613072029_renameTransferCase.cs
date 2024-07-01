using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class renameTransferCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrasnferCase",
                table: "Sub_UnderVehicles",
                newName: "TransferCase");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransferCase",
                table: "Sub_UnderVehicles",
                newName: "TrasnferCase");
        }
    }
}
