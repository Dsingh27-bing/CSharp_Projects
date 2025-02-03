using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication2.Controllers;

public class GenreController : Controller
{
    private readonly IGenreRepository genreRepository;
    public GenreController(IGenreRepository genreRepository) //dependency injection calling --- constructor method
    {
        this.genreRepository = genreRepository;
    }
    // GET
    public IActionResult Index(int pageNumber = 1, int pageSize = 10)
    {
        var result = genreRepository.GetGenresByPages(pageNumber, pageSize);
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id","Name");
        return View(result);
    }
    [HttpGet]
    public IActionResult Create() //just gives the view page, does not save any data
    {
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id","Name");
        return View();
    }
    [HttpPost]
    public IActionResult Create(Genre genre) //saves the data
    {
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id","Name");
        if (ModelState.IsValid)
        {
            genreRepository.Insert(genre);
            return RedirectToAction("Index");
        }
        return View(genre);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id","Name");
        var result = genreRepository.GetById(id);
        return View(result);
    }

    [HttpPost]
    public IActionResult Edit(Genre genre)
    {
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id","Name");
        if (ModelState.IsValid)
        {
            genreRepository.Update(genre);
            return RedirectToAction("Index");
        }

        return View(genre); 
    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id","Name");
        var result = genreRepository.GetById(id);
        return View(result);
    }

    [HttpPost]
    public IActionResult Delete(Genre genre)
    {
        ViewBag.Genres = new SelectList(genreRepository.GetAll(), "Id","Name");
        if (ModelState.IsValid)
        {
            genreRepository.Delete(genre.Id);
            return RedirectToAction("Index");
        }

        return View(genre);
    }
}