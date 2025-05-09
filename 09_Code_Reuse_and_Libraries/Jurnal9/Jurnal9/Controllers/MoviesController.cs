using Microsoft.AspNetCore.Mvc;
using Jurnal9.Models;
using System.Collections.Generic;

namespace Jurnal9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Description = "Two imprisoned men bond over a number of years."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino" },
                Description = "The aging patriarch of an organized crime dynasty transfers control to his reluctant son."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger" },
                Description = "Batman battles the Joker who seeks to undermine Gotham."
            }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound();
            return Ok(Movies[id]);
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            Movies.Add(movie);
            return CreatedAtAction(nameof(GetById), new { id = Movies.Count - 1 }, movie);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound();
            Movies.RemoveAt(id);
            return NoContent();
        }
    }
}
