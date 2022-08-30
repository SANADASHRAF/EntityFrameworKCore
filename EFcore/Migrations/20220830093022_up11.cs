using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    public partial class up11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_project_departments_departmentid",
                table: "project");

            migrationBuilder.AlterColumn<int>(
                name: "departmentid",
                table: "project",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_project_departments_departmentid",
                table: "project",
                column: "departmentid",
                principalTable: "departments",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_project_departments_departmentid",
                table: "project");

            migrationBuilder.AlterColumn<int>(
                name: "departmentid",
                table: "project",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_project_departments_departmentid",
                table: "project",
                column: "departmentid",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
