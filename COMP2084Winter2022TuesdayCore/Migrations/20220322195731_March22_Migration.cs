using Microsoft.EntityFrameworkCore.Migrations;

namespace COMP2084Winter2022TuesdayCore.Migrations
{
    public partial class March22_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployePosition",
                table: "employees",
                newName: "EmployeePosition");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeePosition",
                table: "employees",
                newName: "EmployePosition");
        }
    }
}
