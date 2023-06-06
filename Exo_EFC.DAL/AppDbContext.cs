using Exo_EFC.DAL.Entities;
using Exo_EFC.DAL.FluentApiConfigs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_EFC.DAL
{
    public class AppDbContext : DbContext
    {
        DbSet<Movie> Movies { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=Forma300\TFTIC;Database=Exo_EFC;Trusted_Connection=True"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieConfig());
        }
    }
}
