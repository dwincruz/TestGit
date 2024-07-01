using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class removeMaint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maintenances");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maintenances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateChecked = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    ModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Remarks = table.Column<string>(type: "varchar(512)", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maintenances_Vehicles_VehicleId1",
                        column: x => x.VehicleId1,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_VehicleId1",
                table: "Maintenances",
                column: "VehicleId1");
        }
    }
}
