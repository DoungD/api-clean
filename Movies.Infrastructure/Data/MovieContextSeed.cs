
using Microsoft.Extensions.Logging;
using Movies.Core.Entities;

namespace Movies.Infrastructure.Data;

public static class MovieContextSeed
{
    public static async Task SeedAsync(MovieContext movieContext, ILoggerFactory logger)
    {
        var movies = new List<Movie>
        {
            new Movie { MovieName = "Breaking Bad", DirectorName = "Vince Gilligan", ReleaseYear = "2008"}
        };

        if (movieContext.Movies.Any())
        {
            movieContext.Movies.AddRange(movies);
            await movieContext.SaveChangesAsync();
        }

    }
}
