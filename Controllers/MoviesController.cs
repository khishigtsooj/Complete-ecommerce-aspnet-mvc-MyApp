using Microsoft.AspNetCore.Mvc;
using MovieTickets.Data;
using Microsoft.EntityFrameworkCore;

namespace MovieTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
