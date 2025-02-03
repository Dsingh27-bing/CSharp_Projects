using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using ApplicationCore.Helper;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class MovieRepository: BaseRepository<Movie>, IMovieRepository
{
    private readonly MovieDbContext _movieDbContext;
    public MovieRepository(MovieDbContext dbContext) : base(dbContext)
    {
        _movieDbContext = dbContext;
    }
    
    public PageResultSet<Movie> GetMovies(int pageNumber , int pageSize)
    {
       
        var collection = _movieDbContext.Movies
            .AsNoTracking()
            .OrderBy(m => m.Id);

        int count = collection.Count();

        var pageResultSet = new PageResultSet<Movie>
        {
            PageSize = pageSize,
            ItemCount = count,
            PageCount = (int)Math.Ceiling((double)count / pageSize),
            Items = collection.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
        };

        return pageResultSet;
    

    }
    
    public PageResultSet<Movie> GetMoviesByGenre(int pageNumber, int pageSize, int genreId)
    {
        var collection = _movieDbContext.Movies
            .AsNoTracking()
            .Join(_movieDbContext.MovieGenres,
                movie => movie.Id,
                movieGenre => movieGenre.MovieId,
                (movie, movieGenre) => new { movie, movieGenre })
            .Where(mg => mg.movieGenre.GenreId == genreId)
            .Select(mg => mg.movie)
            .OrderBy(m => m.Id);
            
            

        int count = collection.Count();

        var pageResultSet = new PageResultSet<Movie>
        {
            PageSize = pageSize,
            ItemCount = count,
            PageCount = (int)Math.Ceiling((double)count / pageSize),
            Items = collection.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
        };

        return pageResultSet;
    }
}