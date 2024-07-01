using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class AddUploadFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "PassengerSeat",
            //    table: "Vehicles");

            //migrationBuilder.DropColumn(
            //    name: "Wheels",
            //    table: "Vehicles");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "PassengerSeat",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wheels",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
