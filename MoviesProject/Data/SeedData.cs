using Microsoft.EntityFrameworkCore;
using MoviesProject.Data;
using MoviesProject.Models;

namespace MoviesProject
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        ReleaseDate = DateTime.Parse("1994-10-14"),
                        Genre = "Drama",
                        ImageUrl = "images/shawshank.jpg",
                        Rating = 9.2m
                    },
                    new Movie
                    {
                        Title = "The Godfather",
                        ReleaseDate = DateTime.Parse("1972-03-24"),
                        Genre = "Crime",
                        ImageUrl = "/images/godfather.jpg",
                        Rating = 9.1m
                    },
                    new Movie
                    {
                        Title = "The Dark Knight",
                        ReleaseDate = DateTime.Parse("2008-07-18"),
                        Genre = "Action",
                        ImageUrl = "/images/darkknight.jpg",
                        Rating = 9.0m
                    },
                    new Movie
                    {
                        Title = "Pulp Fiction",
                        ReleaseDate = DateTime.Parse("1994-10-14"),
                        Genre = "Crime",
                        ImageUrl = "/images/pulpfiction.jpg",
                        Rating = 8.9m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}