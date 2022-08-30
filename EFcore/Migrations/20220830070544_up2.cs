using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    public partial class up2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employees",
                table: "employees");

            migrationBuilder.RenameTable(
                name: "employees",
                newName: "employe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employe",
                table: "employe",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employe",
                table: "employe");

            migrationBuilder.RenameTable(
                name: "employe",
                newName: "employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employees",
                table: "employees",
                column: "id");
        }
    }
}
