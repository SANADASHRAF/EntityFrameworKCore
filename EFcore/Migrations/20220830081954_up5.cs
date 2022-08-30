using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    public partial class up5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_departments_Departmentid",
                table: "employee");

            migrationBuilder.RenameColumn(
                name: "Departmentid",
                table: "employee",
                newName: "departmentid");

            migrationBuilder.RenameIndex(
                name: "IX_employee_Departmentid",
                table: "employee",
                newName: "IX_employee_departmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_employee_departments_departmentid",
                table: "employee",
                column: "departmentid",
                principalTable: "departments",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_departments_departmentid",
                table: "employee");

            migrationBuilder.RenameColumn(
                name: "departmentid",
                table: "employee",
                newName: "Departmentid");

            migrationBuilder.RenameIndex(
                name: "IX_employee_departmentid",
                table: "employee",
                newName: "IX_employee_Departmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_employee_departments_Departmentid",
                table: "employee",
                column: "Departmentid",
                principalTable: "departments",
                principalColumn: "id");
        }
    }
}
