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
                Title = "Kill Bill vol. 1",
                ReleaseDate = new(2003, 10, 18),
                Genre = "Action",
                Price = 1500,
            },
            new Movie //no. 2
            { 
                Title = "Kill Bill vol. 2",
                ReleaseDate = new(2004, 04, 25),
                Genre = "Action",
                Price = 1500,
            },
            new Movie //no. 3
            {
                Title = "Cloud Atlas",
                ReleaseDate = new(2012, 11, 22),
                Genre = "Drama",
                Price = 2000,
            },
            new Movie //no. 4
            {
                Title = "The Shawshark Redemption",
                ReleaseDate = new(1994, 05, 25),
                Genre = "Drama",
                Price = 1000,
            },
            new Movie //no. 5
            {
                Title = "The Lord of the Rings: Two Towers",
                ReleaseDate = new(2002, 01, 09),
                Genre = "Adventure",
                Price = 2500,
            },
            new Movie //no. 6
            {
                Title = "The Matrix",
                ReleaseDate = new(1999, 08, 05),
                Genre = "Action",
                Price = 1500,
            },
            new Movie // no. 7
            {
                Title = "One Flew Over the Cuckoo's Nest",
                ReleaseDate = new(1975, 05, 19),
                Genre = "Drama",
                Price = 1000,
            });

        _contex.SaveChanges();
    }
}
