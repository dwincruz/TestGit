using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class RenameLifeSpanFIeldInBrakesAndTires : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lifespan",
                table: "Sub_BrakeTires",
                newName: "LifeSpan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LifeSpan",
                table: "Sub_BrakeTires",
                newName: "Lifespan");
        }
    }
}
