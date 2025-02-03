using ApplicationCore.Entities;
using ApplicationCore.Helper;

namespace ApplicationCore.Contracts.Repository;

public interface IMovieRepository: IRepository<Movie>
{
    PageResultSet<Movie> GetMovies(int pageNumber =1, int pageSize=400);
    PageResultSet<Movie> GetMoviesByGenre(int pageNumber, int pageSize, int genreId);
}