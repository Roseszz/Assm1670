using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.Data.Migrations
{
    public partial class new123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TimePublish = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Author_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    OrderQuantity = table.Column<int>(nullable: false),
                    OrderPrice = table.Column<double>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "Age", "BookId", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 40, 0, "Long@gmail.com", "Long" },
                    { 2, 70, 0, "Minh@gmail.com", "Minh" },
                    { 3, 50, 0, "Khanh@gmail.com", "Khanh" },
                    { 4, 30, 0, "Ha@gmail.com", "Ha" },
                    { 5, 40, 0, "Hanh@gmail.com", "Hanh" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity", "TimePublish" },
                values: new object[,]
                {
                    { 1, "None", "Hamlet ", 100.0, 10, new DateTime(1996, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "None", "The Great Gatsby", 200.0, 10, new DateTime(2000, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "None", "One Hundred Years of Solitude", 400.0, 10, new DateTime(2009, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "None", "Don Quixote", 700.0, 10, new DateTime(2012, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "None", "Moby Dick ", 200.0, 10, new DateTime(2005, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "BookId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 0, " Novel Type", " Novel" },
                    { 2, 0, " Fantasy Type", " Fantasy" },
                    { 3, 0, " Romance Type", " Romance" },
                    { 4, 0, " Horror Type", " Horror" },
                    { 5, 0, " Comedy Type", " Comedy" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Author_BookId",
                table: "Author",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_BookId",
                table: "Category",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookId",
                table: "Order",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
