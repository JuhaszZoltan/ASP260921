using ASP260921.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP260921.Data;

public static class SeedDatabase
{
    public static void Initialize(IServiceProvider provider)
    {
        using ApplicationDbContext _contex 
            = new(provider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

        if (_contex.Movies.Any()) return;

        _contex.Movies.AddRange(
            new Movie //no. 1
            {
                Title = "film",
                ReleaseDate = new(2000, 01, 01),
                Genre = "Comedy",
                Price = 2000,
            },
            new Movie //no. 2
            { 
                Title = "film",
                ReleaseDate = new(2000, 01, 01),
                Genre = "Comedy",
                Price = 2000,
            },
            new Movie //no. 3
            {
                Title = "film",
                ReleaseDate = new(2000, 01, 01),
                Genre = "Comedy",
                Price = 2000,
            },
            new Movie //no. 4
            {
                Title = "film",
                ReleaseDate = new(2000, 01, 01),
                Genre = "Comedy",
                Price = 2000,
            },
            new Movie //no. 5
            {
                Title = "film",
                ReleaseDate = new(2000, 01, 01),
                Genre = "Comedy",
                Price = 2000,
            },
            new Movie //no. 6
            {
                Title = "film",
                ReleaseDate = new(2000, 01, 01),
                Genre = "Comedy",
                Price = 2000,
            },
            new Movie // no. 7
            {
                Title = "film",
                ReleaseDate = new(2000, 01, 01),
                Genre = "Comedy",
                Price = 2000,
            });

        _contex.SaveChanges();
    }
}
