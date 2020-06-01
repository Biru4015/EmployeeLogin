using Microsoft.EntityFrameworkCore.Migrations;

namespace GreetingAppRepositoryLayer.Migrations
{
    public partial class mofgratig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Mobile",
                table: "Employee",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                table: "Employee",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
