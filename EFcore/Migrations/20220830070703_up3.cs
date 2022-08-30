using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    public partial class up3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employe",
                table: "employe");

            migrationBuilder.RenameTable(
                name: "employe",
                newName: "employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employee",
                table: "employee",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_employee",
                table: "employee");

            migrationBuilder.RenameTable(
                name: "employee",
                newName: "employe");

            migrationBuilder.AddPrimaryKey(
                name: "PK_employe",
                table: "employe",
                column: "id");
        }
    }
}
