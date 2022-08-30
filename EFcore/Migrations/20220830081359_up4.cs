using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    public partial class up4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Departmentid",
                table: "employee",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "departmenid",
                table: "employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "branchid",
                table: "departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "maneger",
                columns: table => new
                {
                    manegerid = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maneger", x => new { x.manegerid, x.date });
                });

            migrationBuilder.CreateIndex(
                name: "IX_employee_Departmentid",
                table: "employee",
                column: "Departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_departments_branchid",
                table: "departments",
                column: "branchid");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_branches_branchid",
                table: "departments",
                column: "branchid",
                principalTable: "branches",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_employee_departments_Departmentid",
                table: "employee",
                column: "Departmentid",
                principalTable: "departments",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_branches_branchid",
                table: "departments");

            migrationBuilder.DropForeignKey(
                name: "FK_employee_departments_Departmentid",
                table: "employee");

            migrationBuilder.DropTable(
                name: "maneger");

            migrationBuilder.DropIndex(
                name: "IX_employee_Departmentid",
                table: "employee");

            migrationBuilder.DropIndex(
                name: "IX_departments_branchid",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "Departmentid",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "departmenid",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "branchid",
                table: "departments");
        }
    }
}
