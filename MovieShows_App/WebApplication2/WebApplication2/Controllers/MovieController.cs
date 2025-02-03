using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using ApplicationCore.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication2.Controllers;

public class MovieController : Controller
{
    private readonly IMovieRepository movieRepository;
    private readonly IGenreRepository genreRepository;
    public MovieController(IMovieRepository movieRepository, IGenreRepository genreRepository) //dependency injection calling --- constructor method
    {
        this.movieRepository = movieRepository;
        this.genreRepository = genreRepository;
    }
    // GET
    [HttpGet]
    public IActionResult Index(int pageNumber = 1, int pageSize = 400, int? genreId = null)
    {
        PageResultSet<Movie> resultSet = genreId.HasValue
            ? movieRepository.GetMoviesByGenre(pageNumber, pageSize, genreId.Value)
            : movieRepository.GetMovies(pageNumber, pageSize);
        

        // Populate the genre dropdown
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id", "Name");

        // Keep track of the selected genre for dropdown
        ViewBag.SelectedGenre = genreId;

        return View(resultSet);

       
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id","Name");
        return View();
    }

    [HttpGet]
    public IActionResult Detail(int id)
    {
        var movie = movieRepository.GetById(id);
        if (movie == null)
        {
            return NotFound();
        }

        return View(movie);
    }
}