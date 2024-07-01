using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class addemdateandremarks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Sub_BrakeTires",
                newName: "Remarks");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReplaced",
                table: "Sub_BrakeTires",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateReplaced",
                table: "Sub_BrakeTires");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "Sub_BrakeTires",
                newName: "Status");
        }
    }
}
