using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RSOD.Migrations
{
    /// <inheritdoc />
    public partial class ddddddd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_CollectionGames_CollectionGameId",
                table: "Games");

            migrationBuilder.DropTable(
                name: "CollectionGame");

            migrationBuilder.DropTable(
                name: "CollectionGames");

            migrationBuilder.RenameColumn(
                name: "CollectionGameId",
                table: "Games",
                newName: "CollectionId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_CollectionGameId",
                table: "Games",
                newName: "IX_Games_CollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Collections_CollectionId",
                table: "Games",
                column: "CollectionId",
                principalTable: "Collections",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Collections_CollectionId",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "CollectionId",
                table: "Games",
                newName: "CollectionGameId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_CollectionId",
                table: "Games",
                newName: "IX_Games_CollectionGameId");

            migrationBuilder.CreateTable(
                name: "CollectionGame",
                columns: table => new
                {
                    CollectionsId = table.Column<int>(type: "int", nullable: false),
                    GamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionGame", x => new { x.CollectionsId, x.GamesId });
                    table.ForeignKey(
                        name: "FK_CollectionGame_Collections_CollectionsId",
                        column: x => x.CollectionsId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollectionGame_Games_GamesId",
                        column: x => x.GamesId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollectionGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CollectionGames_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollectionGame_GamesId",
                table: "CollectionGame",
                column: "GamesId");

            migrationBuilder.CreateIndex(
                name: "IX_CollectionGames_CollectionId",
                table: "CollectionGames",
                column: "CollectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_CollectionGames_CollectionGameId",
                table: "Games",
                column: "CollectionGameId",
                principalTable: "CollectionGames",
                principalColumn: "Id");
        }
    }
}
