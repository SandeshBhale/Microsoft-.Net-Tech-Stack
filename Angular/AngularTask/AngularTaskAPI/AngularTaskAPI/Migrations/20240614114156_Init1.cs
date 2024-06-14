using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularTaskAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTable_DepartmentTable_DepartmentDeptId",
                table: "EmployeeTable");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTable_DepartmentDeptId",
                table: "EmployeeTable");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "EmployeeTable");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTable_DeptId",
                table: "EmployeeTable",
                column: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTable_DepartmentTable_DeptId",
                table: "EmployeeTable",
                column: "DeptId",
                principalTable: "DepartmentTable",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTable_DepartmentTable_DeptId",
                table: "EmployeeTable");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTable_DeptId",
                table: "EmployeeTable");

            migrationBuilder.AddColumn<long>(
                name: "DepartmentDeptId",
                table: "EmployeeTable",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTable_DepartmentDeptId",
                table: "EmployeeTable",
                column: "DepartmentDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTable_DepartmentTable_DepartmentDeptId",
                table: "EmployeeTable",
                column: "DepartmentDeptId",
                principalTable: "DepartmentTable",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
