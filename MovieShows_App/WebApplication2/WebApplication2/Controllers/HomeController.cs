using System.Diagnostics;
using ApplicationCore.Contracts.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IGenreRepository genreRepository;

    public HomeController(ILogger<HomeController> logger, IGenreRepository genreRepository)
    {
        _logger = logger;
        this.genreRepository = genreRepository;
    }
    

    public IActionResult Index()
    {
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id","Name");
        return View();
    }

    public IActionResult Privacy()
    {
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id","Name");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    
    {
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id","Name");
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
    
}