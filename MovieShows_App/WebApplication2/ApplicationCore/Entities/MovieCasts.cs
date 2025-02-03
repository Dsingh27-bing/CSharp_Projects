using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities;

public class MovieCasts
{
    [Required]
    public int CastId { get; set; }
    [Required]
    public int MovieId { get; set; }
    [Required]
    [Column (TypeName = "nvarchar(450)")]
    public string Character { get; set; }  
    
    public Casts Cast { get; set; }
    public Movie Movie { get; set; }
    
}