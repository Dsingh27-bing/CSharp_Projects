using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace ApplicationCore.Entities;

public class Casts
{
    public int Id { get; set; }
    [Required]
    [Column (TypeName = "nvarchar(MAX)")]
    public string Gender { get; set; }
    [Required]
    [Column (TypeName = "nvarchar(128)")]
    public string Name { get; set; }
    [Required]
    [Column (TypeName = "nvarchar(2084)")]
    public string ProfilePath { get; set; }
    [Required]
    [Column (TypeName = "nvarchar(MAX)")]
    public string TmdbUrl { get; set; }
    
    public IEnumerable<Movie> Movies { get; set; }
}