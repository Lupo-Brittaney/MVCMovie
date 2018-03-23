using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "Meet the Mormons",
                         ReleaseDate = DateTime.Parse("2014-10-10"),
                         Genre = "Documentary",
                         Rating = "G",
                         Price = 8.99M
                     },

                     new Movie
                     {
                         Title = "The Other Side of Heaven",
                         ReleaseDate = DateTime.Parse("2001-12-14"),
                         Genre = "Romantic Comedy",
                         Rating = "PG",
                         Price = 5.99M
                     },

                     new Movie
                     {
                         Title = "The RM",
                         ReleaseDate = DateTime.Parse("2003-1-31"),
                         Genre = "Comedy",
                         Rating = "PG",
                         Price = 5.99M
                     },

                   new Movie
                   {
                       Title = "Once I was a Beehive",
                       ReleaseDate = DateTime.Parse("2014-12-14"),
                       Genre = "Comedy",
                       Rating = "PG",
                       Price = 8.99M
                   },

                   new Movie
                   {
                       Title = "17 Miracles ",
                       ReleaseDate = DateTime.Parse("2001-03-06"),
                       Genre = "Drama",
                       Rating = "PG",
                       Price = 5.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
