using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudApi.Migrations
{
    /// <inheritdoc />
    public partial class Firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Booktable",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    desceription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bookid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booktable", x => x.id);
                    table.ForeignKey(
                        name: "FK_Booktable_AuthorTable_bookid",
                        column: x => x.bookid,
                        principalTable: "AuthorTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booktable_bookid",
                table: "Booktable",
                column: "bookid",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booktable");

            migrationBuilder.DropTable(
                name: "AuthorTable");
        }
    }
}
