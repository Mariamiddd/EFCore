using EFCore.Data;
using EFCore.Models.Entities;


namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var context = new MovieDbContext();
          context.Database.EnsureCreated(); // migraciebit nacvldeba

            var newCountry = new Country { Name = "USA" };

            var newStudio = new Studio
            {
                Name = "Warner Bros",
                Country = newCountry
            };

            var newMovie = new Movie
            {
                Title = "Inception",
                ReleaseYear = 2010,
                Studio = newStudio
            };

            var newActor = new Actor
            {
                FirstName = "Leonardo",
                LastName = "DiCaprio",
                Movies = new List<Movie> { newMovie }
            };

            context.Movies.Add(newMovie);
            context.Actors.Add(newActor);
            context.SaveChanges();

        }
    }
}
