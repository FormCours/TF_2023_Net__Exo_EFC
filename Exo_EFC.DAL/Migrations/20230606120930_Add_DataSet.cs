using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exo_EFC.DAL.Migrations
{
    public partial class Add_DataSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Movie_Id", "Director", "Genre", "MainActor", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { new Guid("1684fb20-018e-4f70-b18a-a297a1b16ed7"), "Georges Lucas", "Science-Fiction", "Mark Hammil", (short)1977, "Star Wars : Un nouvel espoir" },
                    { new Guid("1bd64d5d-968d-4a54-98d0-6c527034ba3d"), "Georges Lucas", "Science-Fiction", "Mark Hammil", (short)1983, "Star Wars : Le retour du Jedi" },
                    { new Guid("3fd4cba4-0744-4e9f-9573-4b6eebba1047"), "Peter Jackson", "Heroic-Fantasy", "Elijah Wood", (short)2001, "LOTR - La communauté de l'anneau" },
                    { new Guid("c34329df-8d4e-4e79-bc49-7061d1477ceb"), "Georges Lucas", "Science-Fiction", "Mark Hammil", (short)1980, "Star Wars : L'empire contre-attaque" },
                    { new Guid("d99a5b87-699b-44d6-a4ac-df95f07fc966"), "Peter Jackson", "Heroic-Fantasy", "Elijah Wood", (short)2002, "LOTR - Les deux tours" },
                    { new Guid("d99a6011-ed47-40be-8298-abb86e42d1c9"), "Peter Jackson", "Heroic-Fantasy", "Elijah Wood", (short)2003, "LOTR - Le retour du roi" },
                    { new Guid("e142850c-9be4-4b18-9539-d7ba5520214f"), "Lexi Alexander", "Société", "Charlie Hunnam", (short)2005, "Hooligans" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Movie_Id",
                keyValue: new Guid("1684fb20-018e-4f70-b18a-a297a1b16ed7"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Movie_Id",
                keyValue: new Guid("1bd64d5d-968d-4a54-98d0-6c527034ba3d"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Movie_Id",
                keyValue: new Guid("3fd4cba4-0744-4e9f-9573-4b6eebba1047"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Movie_Id",
                keyValue: new Guid("c34329df-8d4e-4e79-bc49-7061d1477ceb"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Movie_Id",
                keyValue: new Guid("d99a5b87-699b-44d6-a4ac-df95f07fc966"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Movie_Id",
                keyValue: new Guid("d99a6011-ed47-40be-8298-abb86e42d1c9"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Movie_Id",
                keyValue: new Guid("e142850c-9be4-4b18-9539-d7ba5520214f"));
        }
    }
}
