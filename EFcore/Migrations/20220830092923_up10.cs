using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    public partial class up10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "attendance",
                columns: table => new
                {
                    employeeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendance", x => x.employeeid);
                });

            migrationBuilder.CreateTable(
                name: "attendanceemployee",
                columns: table => new
                {
                    attendancesemployeeid = table.Column<int>(type: "int", nullable: false),
                    employeesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendanceemployee", x => new { x.attendancesemployeeid, x.employeesid });
                    table.ForeignKey(
                        name: "FK_attendanceemployee_attendance_attendancesemployeeid",
                        column: x => x.attendancesemployeeid,
                        principalTable: "attendance",
                        principalColumn: "employeeid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_attendanceemployee_employee_employeesid",
                        column: x => x.employeesid,
                        principalTable: "employee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_attendanceemployee_employeesid",
                table: "attendanceemployee",
                column: "employeesid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attendanceemployee");

            migrationBuilder.DropTable(
                name: "attendance");
        }
    }
}
