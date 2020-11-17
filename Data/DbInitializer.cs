using System;
using System.Linq;
using Lab21_24.Data.Context;
using Lab21_24.Models;

namespace Lab21_24.Data
{
    public class DbInitializer
    {
        public static void Initialize(MovieDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            var movies = new Movie[]
            {
            new Movie{Title="Inception",Genre=Genre.Action,Runtime=TimeSpan.FromMinutes(148)},
            new Movie{Title="Kingsman: The Secret Service",Genre=Genre.Action,Runtime=TimeSpan.FromMinutes(129)},
            new Movie{Title="Exam",Genre=Genre.Thriller,Runtime=TimeSpan.FromMinutes(101)},
            new Movie{Title="Predestination",Genre=Genre.SciFi,Runtime=TimeSpan.FromMinutes(97)},
            new Movie{Title="Edge of Tomorrow",Genre=Genre.SciFi,Runtime=TimeSpan.FromMinutes(113)},
            new Movie{Title="Looper",Genre=Genre.SciFi,Runtime=TimeSpan.FromMinutes(119)},
            new Movie{Title="Akira",Genre=Genre.Animation,Runtime=TimeSpan.FromMinutes(126)},
            new Movie{Title="Shrek",Genre=Genre.Family,Runtime=TimeSpan.FromMinutes(95)},
            new Movie{Title="Date Night",Genre=Genre.Romance,Runtime=TimeSpan.FromMinutes(102)},
            new Movie{Title="Justice League: Doom",Genre=Genre.Animation,Runtime=TimeSpan.FromMinutes(77)},


            };
            foreach (Movie m in movies)
            {
                context.Movies.Add(m);
            }
            context.SaveChanges();

        
        }
    }
}
