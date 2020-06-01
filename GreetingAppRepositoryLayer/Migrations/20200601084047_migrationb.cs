using Microsoft.EntityFrameworkCore.Migrations;

namespace GreetingAppRepositoryLayer.Migrations
{
    public partial class migrationb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Employee",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(int),
                oldMaxLength: 12);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Mobile",
                table: "Employee",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 12);
        }
    }
}
