using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class monitoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Monitorings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaintenanceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReplacementId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrentKM = table.Column<int>(type: "int", nullable: true),
                    CurrentDays = table.Column<int>(type: "int", nullable: true),
                    ReplacementId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitorings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitorings_Maintenances_MaintenanceId",
                        column: x => x.MaintenanceId,
                        principalTable: "Maintenances",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Monitorings_Replacements_ReplacementId1",
                        column: x => x.ReplacementId1,
                        principalTable: "Replacements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Monitorings_MaintenanceId",
                table: "Monitorings",
                column: "MaintenanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitorings_ReplacementId1",
                table: "Monitorings",
                column: "ReplacementId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monitorings");
        }
    }
}
