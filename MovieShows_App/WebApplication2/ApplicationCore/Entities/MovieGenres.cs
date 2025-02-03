using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.Entities;

public class MovieGenres
{
    [Required]
    public int GenreId { get; set; }
    [Required]
    public int MovieId { get; set; }
    
    public Genre Genre { get; set; }
    public Movie Movie { get; set; }
}