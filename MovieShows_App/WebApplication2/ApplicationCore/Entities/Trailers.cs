using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApplicationCore.Entities;

public class Trailers
{
    
    public int Id { get; set; }
    [Required]
    [Column (TypeName = "int")]
    public int MovieId { get; set; }
    [Required]
    [Column (TypeName = "nvarchar(2084)")]
    public string Name { get; set; }
    [Required]
    [Column (TypeName = "nvarchar(2084)")]
    public string TrailerUrl { get; set; }
    
    public Movie Movies { get; set; }
}