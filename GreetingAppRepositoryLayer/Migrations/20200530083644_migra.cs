using Microsoft.EntityFrameworkCore.Migrations;

namespace GreetingAppRepositoryLayer.Migrations
{
    public partial class migra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "WorkExp",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employee",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "EmailId",
                table: "Employee",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employee",
                newName: "EmpID");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Employee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Employee",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employee",
                newName: "EmailId");

            migrationBuilder.RenameColumn(
                name: "EmpID",
                table: "Employee",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkExp",
                table: "Employee",
                nullable: false,
                defaultValue: 0);
        }
    }
}
