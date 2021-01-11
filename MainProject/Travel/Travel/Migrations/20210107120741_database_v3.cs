using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class database_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NamePlace",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NamePlace",
                table: "Movie");
        }
    }
}
