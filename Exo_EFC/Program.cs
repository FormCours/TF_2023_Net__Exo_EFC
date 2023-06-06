using Exo_EFC.DAL;
using Exo_EFC.DAL.Entities;

Console.WriteLine("Exo EFC");
Console.WriteLine("*******");
Console.WriteLine();

// Utilisation de EFC
using(AppDbContext db = new AppDbContext())
{
    // Ajouter le film “Pacific Rim” (Acteur principal : Charlie Hunnam, Réal : Guillermo Del Toro, Année : 2013, Genre: Action)
    Console.WriteLine("Ajout du film \"Pacific Rim\"");
    db.Movies.Add(new Movie
    {
        Title = "Pacific Rim",
        MainActor = "Charlie Hunnam",
        Director = "Guillermo Del Toro",
        ReleaseYear = 2013,
        Genre = "Action"
    });
    db.SaveChanges();
    Console.WriteLine();


    // Sélectionner et afficher tous les films sortis avant 2001
    var moviesBefore2001 = db.Movies.Where(m => m.ReleaseYear < 2001);

    Console.WriteLine("Liste des films sortis avant 2001 : ");
    foreach (Movie movie in moviesBefore2001)
    {
        Console.WriteLine($" - {movie.Title} {movie.ReleaseYear}");
    }
    Console.WriteLine();

    // Mettre à jour tous les films Star Wars pour remplacer l’acteur principal par Harrison Ford
    var allStarWars = db.Movies.Where(m => m.Title.StartsWith("Star Wars"));

    foreach (Movie movie in allStarWars)
    {
        movie.MainActor = "Harrison Ford";
    }
    db.SaveChanges();


    // Supprimer tous les films de Charlie Hunnam
    var allCharlieHunnam = db.Movies
                             .Where(m => m.MainActor == "Charlie Hunnam");

    db.Movies.RemoveRange(allCharlieHunnam);
    db.SaveChanges();
}