using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class RenameLifeSpanFIeldInMonitorings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lifespan",
                table: "Monitorings",
                newName: "LifeSpan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LifeSpan",
                table: "Monitorings",
                newName: "Lifespan");
        }
    }
}
