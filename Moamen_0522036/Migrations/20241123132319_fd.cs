using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moamen_0522036.Migrations
{
    /// <inheritdoc />
    public partial class fd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "directors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectorModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nationalities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nationalities_directors_DirectorModelId",
                        column: x => x.DirectorModelId,
                        principalTable: "directors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CategoryModeMoviesModel",
                columns: table => new
                {
                    MoviesId = table.Column<int>(type: "int", nullable: false),
                    categoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModeMoviesModel", x => new { x.MoviesId, x.categoriesId });
                    table.ForeignKey(
                        name: "FK_CategoryModeMoviesModel_categories_categoriesId",
                        column: x => x.categoriesId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryModeMoviesModel_movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DirectorModelMoviesModel",
                columns: table => new
                {
                    DirectorsId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectorModelMoviesModel", x => new { x.DirectorsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_DirectorModelMoviesModel_directors_DirectorsId",
                        column: x => x.DirectorsId,
                        principalTable: "directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectorModelMoviesModel_movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryModeMoviesModel_categoriesId",
                table: "CategoryModeMoviesModel",
                column: "categoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_DirectorModelMoviesModel_MoviesId",
                table: "DirectorModelMoviesModel",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_nationalities_DirectorModelId",
                table: "nationalities",
                column: "DirectorModelId",
                unique: true,
                filter: "[DirectorModelId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryModeMoviesModel");

            migrationBuilder.DropTable(
                name: "DirectorModelMoviesModel");

            migrationBuilder.DropTable(
                name: "nationalities");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "directors");
        }
    }
}
