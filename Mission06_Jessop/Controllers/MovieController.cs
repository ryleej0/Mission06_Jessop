using Microsoft.AspNetCore.Mvc;
using Mission06_Jessop.Models;

namespace Mission06_Jessop.Controllers;

/// <summary>
/// Controller for Joel Hilton's Movie Collection.
/// Handles viewing, adding, editing, and deleting movies.
/// Mission 7: List, Update, Delete functionality with validation.
/// </summary>
public class MovieController : Controller
{
    private readonly MovieContext _context;

    public MovieController(MovieContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Display the form to add a new movie to the collection.
    /// </summary>
    [HttpGet]
    public IActionResult AddMovie()
    {
        return View();
    }

    /// <summary>
    /// Process the add movie form. Validates required fields: Title, Year, Edited, CopiedToPlex.
    /// Year must be 1888 or later.
    /// </summary>
    [HttpPost]
    public IActionResult AddMovie(Movie movie)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }
        return View(movie);
    }

    /// <summary>
    /// Display all movies in the collection, sorted by title.
    /// </summary>
    public IActionResult MovieList()
    {
        var movies = _context.Movies.OrderBy(m => m.Title).ToList();
        return View(movies);
    }

    /// <summary>
    /// Display the edit form for a specific movie.
    /// </summary>
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var movie = _context.Movies.Find(id);
        if (movie == null)
            return NotFound();
        return View(movie);
    }

    [HttpPost]
    public IActionResult Edit(Movie movie)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }
        return View(movie);
    }

    /// <summary>
    /// Display the delete confirmation page for a specific movie.
    /// </summary>
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var movie = _context.Movies.Find(id);
        if (movie == null)
            return NotFound();
        return View(movie);
    }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var movie = _context.Movies.Find(id);
        if (movie != null)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
        return RedirectToAction("MovieList");
    }
}
