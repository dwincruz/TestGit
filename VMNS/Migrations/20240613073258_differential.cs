using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class differential : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Diffential",
                table: "Sub_UnderVehicles",
                newName: "Differential");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Differential",
                table: "Sub_UnderVehicles",
                newName: "Diffential");
        }
    }
}
