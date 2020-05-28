using Microsoft.EntityFrameworkCore.Migrations;

namespace GreetingAppRepositoryLayer.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    WorkExp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
