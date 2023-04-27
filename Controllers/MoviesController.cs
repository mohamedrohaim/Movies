using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using System.Runtime.InteropServices;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        public readonly ApplicationDbContext _context;


        public MoviesController(ApplicationDbContext context)
        {
            _context =context;
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
