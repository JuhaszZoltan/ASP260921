using ASP260921.Models;
using Microsoft.EntityFrameworkCore;


namespace ASP260921.Data;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; } = default!;
}