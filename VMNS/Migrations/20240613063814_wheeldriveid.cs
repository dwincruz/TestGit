using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class wheeldriveid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "lu_WheelDriveId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_lu_WheelDriveId",
                table: "Vehicles",
                column: "lu_WheelDriveId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_lu_WheelDrives_lu_WheelDriveId",
                table: "Vehicles",
                column: "lu_WheelDriveId",
                principalTable: "lu_WheelDrives",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_lu_WheelDrives_lu_WheelDriveId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_lu_WheelDriveId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "lu_WheelDriveId",
                table: "Vehicles");
        }
    }
}
