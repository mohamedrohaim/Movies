using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.Models;
using Movies.ViewModel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        public readonly ApplicationDbContext _context;
        private  List<string> _allowedExtentions=new List<string>() {".jpg",".png" };
        private long _MaxPosterSize = 1048576;



		public MoviesController(ApplicationDbContext context)
        {
            _context =context;
        }



        public async Task<IActionResult> Index()
        {
            var movies=await _context.Movies.ToListAsync();
            return View(movies);
        }
        public async Task<IActionResult> Create()
        {
            var viewModel=new MovieViewModel() { 
            Genres=await _context.Genres.OrderBy(m=>m.Name).ToListAsync(),
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(MovieViewModel model)
		{
			var Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
			if (!ModelState.IsValid) {
				
                model.Genres = Genres;
				return View(model);
            }
            var files = Request.Form.Files;
            if (!files.Any()) {

                model.Genres = Genres;
                ModelState.AddModelError("Poster", "Please select movie poster");
                return View(model);
            }
            var poster=files.FirstOrDefault();
            
            if (!_allowedExtentions.Contains(Path.GetExtension(poster.FileName).ToLower())) {
				model.Genres = Genres;
				ModelState.AddModelError("Poster", "not allowed extention only jpg and png are allowed");
				return View(model);
			}
            if (poster.Length > _MaxPosterSize) {
				model.Genres = Genres;
				ModelState.AddModelError("Poster", "you must select poster smaller than 1 MB");
				return View(model);
			}

            using var DataStream=new MemoryStream();
            await poster.CopyToAsync(DataStream);
            var movie = new Movie()
            {
                Title= model.Title,
                Rate= model.Rate,
                Year= model.Year,
                StoryLine= model.StoryLine,
                GenreId= model.GenreId,
                Poster=DataStream.ToArray(),

            };
            _context.Movies.Add(movie);
            _context.SaveChanges();

			return RedirectToAction(nameof(Index));
		}


        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return BadRequest();
            }
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            var viewModel = new MovieViewModel() {
                Id =movie.Id,
                Title=movie.Title,
                Rate=movie.Rate,
                Year=movie.Year,
                StoryLine=movie.StoryLine,
                GenreId=movie.GenreId,
                Poster=movie.Poster,
                Genres=await _context.Genres.ToListAsync(),
            };

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(MovieViewModel model) {

			var Genres = await _context.Genres.OrderBy(m => m.Name).ToListAsync();
			if (!ModelState.IsValid)
			{
				model.Genres = Genres;
				return View(model);
			}

            var movie =await _context.Movies.FindAsync(model.Id);
            if (movie == null)
            {
                return NotFound();
            }

			var files = Request.Form.Files;
            if (files.Any())
            {
                var poster = files.FirstOrDefault();
                using var dataStream=new MemoryStream();
                await poster.CopyToAsync(dataStream);
                model.Poster= dataStream.ToArray();
                if (!_allowedExtentions.Contains(Path.GetExtension(poster.FileName).ToLower()))
                {
                    model.Genres = Genres;
                    ModelState.AddModelError("Poster", "not allowed extention only jpg and png are allowed");
                    return View(model);
                }
                if (poster.Length > _MaxPosterSize)
                {
                    model.Genres = Genres;
                    ModelState.AddModelError("Poster", "you must select poster smaller than 1 MB");
                    return View(model);
                }
                movie.Poster=model.Poster;

            }




			movie.Title = model.Title;
			movie.Rate = model.Rate;
			movie.Year = model.Year;
			movie.StoryLine = model.StoryLine;
			movie.GenreId = model.GenreId;

			_context.Movies.Update(movie);
			_context.SaveChanges();
			return RedirectToAction(nameof(Index));
        
        }

    }
}
