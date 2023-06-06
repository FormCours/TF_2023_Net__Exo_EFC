using Exo_EFC.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exo_EFC.DAL.FluentApiConfigs
{
    internal class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            // - Nom de la table
            builder.ToTable("Movie");

            // - Clef primaire
            builder.HasKey(m => m.MovieId).IsClustered();

            // - Colonnes
            builder.Property(m => m.MovieId)
                .HasColumnName("Movie_Id")
                .HasDefaultValueSql("NEWSEQUENTIALID()");
            builder.Property(m => m.Title)
                .HasMaxLength(100)
                .IsRequired();
            builder.HasIndex(m => m.Title)
                .IsUnique();
            builder.Property(m => m.Director)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(m => m.MainActor)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(m => m.Genre)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(m => m.ReleaseYear)
                .IsRequired();

            // - Contrainte
            builder.HasCheckConstraint(
                    "CK_Movie__ReleaseYear",
                    "ReleaseYear > 1975"
            );
        }
    }
}
