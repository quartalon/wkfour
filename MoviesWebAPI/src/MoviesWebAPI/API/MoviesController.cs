using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesWebAPI.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesWebAPI.API
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        static List<Movie> _movies = new List<Movie>
        {
            new Movie(1, "Italian Job", "G. Gray"),
            new Movie(2, "The Love Bug", "R. Stevenson"),
            new Movie(3, "48 Hrs.", "W. Hill"),
            new Movie(4, "Gone in 60 Seconds", "H.B. Halicki")
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _movies;
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            Movie movToReturn = null;
            foreach(Movie mov in _movies)
            {
                if(mov.Id == id)
                {
                    movToReturn = mov;
                }
            }
            return movToReturn;
        }
    }
}
