using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace ApplicationCore.Entities;

public class Movie
{
    
    public int Id { get; set; }
    [Column (TypeName = "nvarchar(2084)")]
    public string? BackdropUrl { get; set; }
    [Column (TypeName = "Decimal(18,4)")]
    public decimal? Budget { get; set; }
    
    [Column (TypeName = "nvarchar(MAX)")]
    public string? CreatedBy { get; set; }
    [Column (TypeName = "Datetime")]
    public DateTime? CreatedDate { get; set; }
    [Column(TypeName ="nvarchar(2084)")]
    public string? ImdbUrl { get; set; }
    [Column (TypeName = "nvarchar(64)")]
    public string? OriginalLanguage { get; set; }
    [Column (TypeName = "nvarchar(MAX)")]
    public string? Overview { get; set; }
    [Column (TypeName= "nvarchar(2084)")]
    public string? PosterUrl { get; set; }
    [Column (TypeName = "Decimal(5,2)")]
    public double? Price { get; set; }
    [Column (TypeName = "Datetime")]
    public DateTime? ReleaseDate { get; set; }
    [Column (TypeName = "Decimal(18,4)")]
    public decimal? Revenue { get; set; }
    [Column (TypeName = "Int")]
    public int? RunTime { get; set; }
    [Column (TypeName = "nvarchar(512)")]
    public string? Tagline { get; set; }
    [Column (TypeName="varchar(256)")]
    public string? Title { get; set; }
    [Column (TypeName = "nvarchar(2084)")]
    public string? TmdbUrl { get; set; }
    [Column(TypeName ="varchar(MAX)")]
    public string? UpdatedBy { get; set; }
    [Column (TypeName = "Datetime")]
    public DateTime? UpdatedDate { get; set; }
    
    public IEnumerable<Genre> Genres { get; set; }
    public IEnumerable<Casts> Casts { get; set; }
    public IEnumerable<Trailers> Trailers { get; set; }
}