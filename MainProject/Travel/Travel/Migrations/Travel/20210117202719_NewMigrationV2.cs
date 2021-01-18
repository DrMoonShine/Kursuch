using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations.Travel
{
    public partial class NewMigrationV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bunch_Movie_PlaceID",
                table: "Bunch");

            migrationBuilder.DropForeignKey(
                name: "FK_Bunch_Route_RouteID",
                table: "Bunch");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Movie_PlaceID",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "TimeTable");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Place");

            migrationBuilder.RenameColumn(
                name: "RouteID",
                table: "Bunch",
                newName: "UserRouteID");

            migrationBuilder.RenameIndex(
                name: "IX_Bunch_RouteID",
                table: "Bunch",
                newName: "IX_Bunch_UserRouteID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Place",
                table: "Place",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserRoute",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameRoute = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discript = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoute", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Bunch_Place_PlaceID",
                table: "Bunch",
                column: "PlaceID",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bunch_UserRoute_UserRouteID",
                table: "Bunch",
                column: "UserRouteID",
                principalTable: "UserRoute",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Place_PlaceID",
                table: "Photo",
                column: "PlaceID",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bunch_Place_PlaceID",
                table: "Bunch");

            migrationBuilder.DropForeignKey(
                name: "FK_Bunch_UserRoute_UserRouteID",
                table: "Bunch");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Place_PlaceID",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "UserRoute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Place",
                table: "Place");

            migrationBuilder.RenameTable(
                name: "Place",
                newName: "Movie");

            migrationBuilder.RenameColumn(
                name: "UserRouteID",
                table: "Bunch",
                newName: "RouteID");

            migrationBuilder.RenameIndex(
                name: "IX_Bunch_UserRouteID",
                table: "Bunch",
                newName: "IX_Bunch_RouteID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RateRoute = table.Column<int>(type: "int", nullable: false),
                    ReviewRoute = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeTable_Route_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Route",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimeTable_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimeTable_RouteID",
                table: "TimeTable",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_TimeTable_UserID",
                table: "TimeTable",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bunch_Movie_PlaceID",
                table: "Bunch",
                column: "PlaceID",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bunch_Route_RouteID",
                table: "Bunch",
                column: "RouteID",
                principalTable: "Route",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Movie_PlaceID",
                table: "Photo",
                column: "PlaceID",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
