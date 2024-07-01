using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class Maintenance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "MaintenanceId",
                table: "Vehicles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Maintenances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateChecked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Remarks = table.Column<string>(type: "varchar(512)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenances", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_MaintenanceId",
                table: "Vehicles",
                column: "MaintenanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Maintenances_MaintenanceId",
                table: "Vehicles",
                column: "MaintenanceId",
                principalTable: "Maintenances",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Maintenances_MaintenanceId",
                table: "Vehicles");

            migrationBuilder.DropTable(
                name: "Maintenances");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_MaintenanceId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "MaintenanceId",
                table: "Vehicles");
        }
    }
}
