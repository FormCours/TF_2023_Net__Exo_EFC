using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Exo_EFC.DAL.Entities;

namespace Exo_EFC.DAL.Seeds
{
    internal class MovieSeed : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData(
                new Movie
                {
                    MovieId = Guid.NewGuid(),
                    Title = "Star Wars : Un nouvel espoir",
                    ReleaseYear = 1977,
                    MainActor = "Mark Hammil",
                    Genre = "Science-Fiction",
                    Director = "Georges Lucas"
                },
                new Movie
                {
                    MovieId = Guid.NewGuid(),
                    Title = "Star Wars : L'empire contre-attaque",
                    ReleaseYear = 1980,
                    MainActor = "Mark Hammil",
                    Genre = "Science-Fiction",
                    Director = "Georges Lucas"
                },
                new Movie
                {
                    MovieId = Guid.NewGuid(),
                    Title = "Star Wars : Le retour du Jedi",
                    ReleaseYear = 1983,
                    MainActor = "Mark Hammil",
                    Genre = "Science-Fiction",
                    Director = "Georges Lucas"
                },
                new Movie
                {
                    MovieId = Guid.NewGuid(),
                    Title = "Hooligans",
                    ReleaseYear = 2005,
                    MainActor = "Charlie Hunnam",
                    Genre = "Société",
                    Director = "Lexi Alexander"
                },
                new Movie
                {
                    MovieId = Guid.NewGuid(),
                    Title = "LOTR - La communauté de l'anneau",
                    ReleaseYear = 2001,
                    MainActor = "Elijah Wood",
                    Genre = "Heroic-Fantasy",
                    Director = "Peter Jackson"
                },
                new Movie
                {
                    MovieId = Guid.NewGuid(),
                    Title = "LOTR - Les deux tours",
                    ReleaseYear = 2002,
                    MainActor = "Elijah Wood",
                    Genre = "Heroic-Fantasy",
                    Director = "Peter Jackson"
                },
                new Movie
                {
                    MovieId = Guid.NewGuid(),
                    Title = "LOTR - Le retour du roi",
                    ReleaseYear = 2003,
                    MainActor = "Elijah Wood",
                    Genre = "Heroic-Fantasy",
                    Director = "Peter Jackson"
                }
                );
        }
    }
}
