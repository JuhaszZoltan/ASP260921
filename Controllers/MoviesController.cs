
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP260921.Models;
using ASP260921.Data;

namespace ASP260921.Controllers;

public class MoviesController : Controller
{
    private readonly ApplicationDbContext _context;

    public MoviesController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: ~/movies/[index]
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Movies.ToListAsync());
    }

    // GET: ~/movies/details/{id:int}
    public async Task<IActionResult> Details(int? id)
    {
        if (id is null) return NotFound();

        var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

        if (movie is null) return NotFound();

        return View(movie);
    }

    // GET: ~/movies/create
    public IActionResult Create()
    {
        return View();
    }

    // POST: ~/movies/create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,Title,ReleaseDate,Genre,Price")] Movie movie)
    {
        if (ModelState.IsValid)
        {
            _context.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(movie);
    }

    // GET: ~/movies/edit/{id:int}
    public async Task<IActionResult> Edit(int? id)
    {
        if (id is null) return NotFound();

        var movie = await _context.Movies.FindAsync(id);

        if (movie is null) return NotFound();

        return View(movie);
    }

    // POST: ~/movies/edit/{id:int}
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,Title,ReleaseDate,Genre,Price")] Movie movie)
    {
        if (id != movie.Id) return NotFound();

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(movie);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(movie.Id)) return NotFound();
                else throw;
            }
            return RedirectToAction(nameof(Index));
        }
        return View(movie);
    }

    // GET: ~/movies/delete/{id:int}
    public async Task<IActionResult> Delete(int? id)
    {
        if (id is null) return NotFound();

        var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

        if (movie is null) return NotFound();

        return View(movie);
    }

    // POST: ~/movies/delete/{id:int}
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var movie = await _context.Movies.FindAsync(id);

        if (movie is not null) _context.Movies.Remove(movie);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    private bool MovieExists(int? id) => _context.Movies.Any(m => m.Id == id);
}
