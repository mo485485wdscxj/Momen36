using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Moamen_0522036.Migrations
{
    /// <inheritdoc />
    public partial class fs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nationalities_directors_DirectorModelId",
                table: "nationalities");

            migrationBuilder.AddForeignKey(
                name: "FK_nationalities_directors_DirectorModelId",
                table: "nationalities",
                column: "DirectorModelId",
                principalTable: "directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_nationalities_directors_DirectorModelId",
                table: "nationalities");

            migrationBuilder.AddForeignKey(
                name: "FK_nationalities_directors_DirectorModelId",
                table: "nationalities",
                column: "DirectorModelId",
                principalTable: "directors",
                principalColumn: "Id");
        }
    }
}
