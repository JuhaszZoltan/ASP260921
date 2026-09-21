using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP260921.Models;

[Table(name:"Movies")]
public class Movie
{
    // POCO Pale Old CLR Object / Pure Old C# Pbject

    public int Id { get; set; }
    [Required]
    [MaxLength(40)]
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    [Required]
    [MaxLength(20)]
    public string? Genre { get; set; }
    [DataType(DataType.Currency)]
    public int Price { get; set; }
}
