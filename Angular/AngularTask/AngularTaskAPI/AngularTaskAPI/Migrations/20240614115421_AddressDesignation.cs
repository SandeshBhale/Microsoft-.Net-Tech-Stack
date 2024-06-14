using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularTaskAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddressDesignation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "EmployeeTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "EmployeeTable",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "EmployeeTable");

            migrationBuilder.DropColumn(
                name: "Designation",
                table: "EmployeeTable");
        }
    }
}
