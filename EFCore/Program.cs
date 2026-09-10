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

            var newMovie = new Movie { Title = "Inception" };

            var newActor = new Actor
            {
                firstName = "Leonardo",
                lastName = "DiCaprio",
                Movies = new List<Movie> { newMovie }


            };


            context.Movies.Add(newMovie);
            context.Actors.Add(newActor);
            context.SaveChanges();

        }
    }
}
