using Microsoft.EntityFrameworkCore.Migrations;

namespace entityframeworkDotnetcore.Migrations
{
    public partial class employeescheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nvarchar(50)",
                table: "Employees",
                newName: "EmployeName");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeName",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeLocation",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfficeLocation",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "EmployeName",
                table: "Employees",
                newName: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(50)",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
