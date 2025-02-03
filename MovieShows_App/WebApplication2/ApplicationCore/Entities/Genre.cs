
namespace ApplicationCore.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Genre
{
    public int Id { get; set; }
    [Required (ErrorMessage= "Genre Name is required!")]
    [Column (TypeName = "varchar(50)")]
    public string Name { get; set; }

    public IEnumerable<Movie> Movies { get; set; } = new List<Movie>();
}