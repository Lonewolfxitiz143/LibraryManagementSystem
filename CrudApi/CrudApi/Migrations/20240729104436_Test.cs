using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudApi.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booktable_AuthorTable_bookid",
                table: "Booktable");

            migrationBuilder.DropIndex(
                name: "IX_Booktable_bookid",
                table: "Booktable");

            migrationBuilder.DropColumn(
                name: "bookid",
                table: "Booktable");

            migrationBuilder.DropColumn(
                name: "authorid",
                table: "AuthorTable");

            migrationBuilder.RenameColumn(
                name: "desceription",
                table: "Booktable",
                newName: "description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "Booktable",
                newName: "desceription");

            migrationBuilder.AddColumn<int>(
                name: "bookid",
                table: "Booktable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "authorid",
                table: "AuthorTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Booktable_bookid",
                table: "Booktable",
                column: "bookid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Booktable_AuthorTable_bookid",
                table: "Booktable",
                column: "bookid",
                principalTable: "AuthorTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
