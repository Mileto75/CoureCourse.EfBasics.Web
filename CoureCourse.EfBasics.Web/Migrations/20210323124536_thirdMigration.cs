using Microsoft.EntityFrameworkCore.Migrations;

namespace CoureCourse.EfBasics.Web.Migrations
{
    public partial class thirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HomeTown",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeTown",
                table: "Teachers");
        }
    }
}
