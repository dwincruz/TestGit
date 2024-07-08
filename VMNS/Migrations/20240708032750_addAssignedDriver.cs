using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VMNS.Migrations
{
    public partial class addAssignedDriver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
               name: "AssignedDriver",
               table: "Vehicles",
               type: "nvarchar(max)",
               nullable: true,
               defaultValue: "");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "AssignedDriver",
               table: "Vehicles");
        }
    }
}
