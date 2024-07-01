using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class Uploadfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Upload",
                table: "Maintenances",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Upload",
                table: "Maintenances",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");
        }
    }
}
