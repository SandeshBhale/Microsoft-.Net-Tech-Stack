using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularTaskAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentTable",
                columns: table => new
                {
                    DeptId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentTable", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTable",
                columns: table => new
                {
                    EmpId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmpSal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptId = table.Column<long>(type: "bigint", nullable: false),
                    DepartmentDeptId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTable", x => x.EmpId);
                    table.ForeignKey(
                        name: "FK_EmployeeTable_DepartmentTable_DepartmentDeptId",
                        column: x => x.DepartmentDeptId,
                        principalTable: "DepartmentTable",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTable_DepartmentDeptId",
                table: "EmployeeTable",
                column: "DepartmentDeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTable");

            migrationBuilder.DropTable(
                name: "DepartmentTable");
        }
    }
}
