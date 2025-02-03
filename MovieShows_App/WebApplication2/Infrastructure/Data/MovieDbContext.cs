using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class MovieDbContext: DbContext
{
    public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
    {
        
    }
    public DbSet<Movie> Movies { get; set; } //entity followed by tablename in database 
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Casts> Casts { get; set; }
    public DbSet<MovieCasts> MovieCasts { get; set; }
    public DbSet<MovieGenres> MovieGenres { get; set; }
    public DbSet<Trailers> Trailers { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MovieCasts>()
            .HasKey(mc => new { mc.MovieId, mc.CastId });

        modelBuilder.Entity<MovieGenres>()
            .HasKey(mg => new { mg.MovieId, mg.GenreId });
        
    }


}
