using Movies.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Movies.ViewModel
{
    public class MovieViewModel
    {

        [Required(ErrorMessage ="title must not be empty"), StringLength(250)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year must not be empty")]

		public int Year { get; set; }
        [Required(ErrorMessage = "Range must not be empty")]
        [Range(1,10,ErrorMessage = "Rate must not be in Range 1 to 10")]
        public double Rate { get; set; }

        [Required, StringLength(2500)]
        public string StoryLine { get; set; }
        [Display(Name ="Select Poster")]
        public byte[] Poster { get; set; }

        [Display(Name ="Genre")]
        public byte GenreId { get; set; }
        public IEnumerable<Genre> Genres{ get; set; }
    }
}
