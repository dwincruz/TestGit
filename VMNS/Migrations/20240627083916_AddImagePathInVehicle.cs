using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class AddImagePathInVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Uploads_carImageId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_carImageId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "carImageId",
                table: "Vehicles");

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "carImageId",
                table: "Vehicles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_carImageId",
                table: "Vehicles",
                column: "carImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Uploads_carImageId",
                table: "Vehicles",
                column: "carImageId",
                principalTable: "Uploads",
                principalColumn: "Id");
        }
    }
}
