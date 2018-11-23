using Microsoft.EntityFrameworkCore.Migrations;

namespace Songs.Migrations
{
    public partial class AddpropertySong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Songs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Songs");
        }
    }
}
