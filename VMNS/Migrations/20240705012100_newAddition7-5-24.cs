using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class newAddition7524 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AutosweepRFID",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cost",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EasyTripRFID",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "lu_VehicleStatusId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "lu_VehicleStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleStatus = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lu_VehicleStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_lu_VehicleStatusId",
                table: "Vehicles",
                column: "lu_VehicleStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_lu_VehicleStatus_lu_VehicleStatusId",
                table: "Vehicles",
                column: "lu_VehicleStatusId",
                principalTable: "lu_VehicleStatus",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_lu_VehicleStatus_lu_VehicleStatusId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "lu_VehicleStatus");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_lu_VehicleStatusId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "AutosweepRFID",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "EasyTripRFID",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "lu_VehicleStatusId",
                table: "Vehicles");
        }
    }
}
