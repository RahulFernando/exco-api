using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace exco_api.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lendings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    img = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lendings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    img = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Lendings",
                columns: new[] { "id", "img", "name" },
                values: new object[,]
                {
                    { 1, "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1327144697l/3744438.jpg", "1984 by george orwell" },
                    { 2, "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1566425108l/33.jpg", "The Lord of the Rings by J.R.R. Tolkien" }
                });

            migrationBuilder.InsertData(
                table: "References",
                columns: new[] { "id", "img", "name" },
                values: new object[,]
                {
                    { 1, "https://i.pinimg.com/originals/a7/41/83/a741836e774ae812b4fd45f9bcc14dbe.png", "Publication Manual of the American Psychological Association" },
                    { 2, "https://images-na.ssl-images-amazon.com/images/I/71pAQQsWJFL.jpg", "The Secrets of Character" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lendings");

            migrationBuilder.DropTable(
                name: "References");
        }
    }
}
