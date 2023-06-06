using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exo_EFC.DAL.Migrations
{
    public partial class Initial_DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Movie_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Director = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MainActor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReleaseYear = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Movie_Id)
                        .Annotation("SqlServer:Clustered", true);
                    table.CheckConstraint("CK_Movie__ReleaseYear", "ReleaseYear > 1975");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_Title",
                table: "Movie",
                column: "Title",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
