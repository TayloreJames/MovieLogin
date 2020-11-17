using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab21_24.Migrations
{
    public partial class AddMovieDbtoApplicationDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Genre = table.Column<int>(nullable: false),
                    Runtime = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Genre", "Runtime", "Title" },
                values: new object[,]
                {
                    { 1, 0, new TimeSpan(0, 2, 28, 0, 0), "Inception" },
                    { 2, 0, new TimeSpan(0, 2, 9, 0, 0), "Kingsman: The Secret Service" },
                    { 3, 2, new TimeSpan(0, 1, 41, 0, 0), "Exam" },
                    { 4, 1, new TimeSpan(0, 1, 37, 0, 0), "Predestination" },
                    { 5, 1, new TimeSpan(0, 1, 53, 0, 0), "Edge of Tomorrow" },
                    { 6, 1, new TimeSpan(0, 1, 59, 0, 0), "Looper" },
                    { 7, 6, new TimeSpan(0, 2, 6, 0, 0), "Akira" },
                    { 8, 7, new TimeSpan(0, 1, 35, 0, 0), "Shrek" },
                    { 9, 8, new TimeSpan(0, 1, 42, 0, 0), "Date Night" },
                    { 10, 6, new TimeSpan(0, 1, 17, 0, 0), "Justice League: Doom" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
