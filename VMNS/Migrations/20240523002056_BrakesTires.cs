using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class BrakesTires : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sub_BrakeTires",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    lu_WheelId = table.Column<int>(type: "int", nullable: true),
                    BreakLining = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TireTread = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WearPattern = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TirePressureBefore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TirePressureAfter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sub_BrakeTires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sub_BrakeTires_lu_Wheels_lu_WheelId",
                        column: x => x.lu_WheelId,
                        principalTable: "lu_Wheels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sub_BrakeTires_Vehicles_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sub_BrakeTires_lu_WheelId",
                table: "Sub_BrakeTires",
                column: "lu_WheelId");

            migrationBuilder.CreateIndex(
                name: "IX_Sub_BrakeTires_VehicleId",
                table: "Sub_BrakeTires",
                column: "VehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sub_BrakeTires");
        }
    }
}
