using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    public partial class up7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "departmenid",
                table: "employee",
                newName: "Departmenid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Departmenid",
                table: "employee",
                newName: "departmenid");
        }
    }
}
