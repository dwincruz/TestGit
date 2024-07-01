using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class damagescale2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DamageScale",
                table: "Accidents");

            migrationBuilder.AddColumn<int>(
                name: "lu_DamageScaleId",
                table: "Accidents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accidents_lu_DamageScaleId",
                table: "Accidents",
                column: "lu_DamageScaleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accidents_lu_DamageScales_lu_DamageScaleId",
                table: "Accidents",
                column: "lu_DamageScaleId",
                principalTable: "lu_DamageScales",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accidents_lu_DamageScales_lu_DamageScaleId",
                table: "Accidents");

            migrationBuilder.DropIndex(
                name: "IX_Accidents_lu_DamageScaleId",
                table: "Accidents");

            migrationBuilder.DropColumn(
                name: "lu_DamageScaleId",
                table: "Accidents");

            migrationBuilder.AddColumn<string>(
                name: "DamageScale",
                table: "Accidents",
                type: "varchar(128)",
                nullable: false,
                defaultValue: "");
        }
    }
}
