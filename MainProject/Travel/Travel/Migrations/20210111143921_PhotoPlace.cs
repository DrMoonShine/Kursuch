using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class PhotoPlace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceID = table.Column<int>(type: "int", nullable: false),
                    RPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Place = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photo_Movie_PlaceID",
                        column: x => x.PlaceID,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_PlaceID",
                table: "Photo",
                column: "PlaceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photo");
        }
    }
}
