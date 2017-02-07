using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        //public decimal Year { get; set; }

        public string Director { get; set; }

        public Movie(int id, string title, string director)
        {
            Id = id;
            Title = title;
            Director = director;
        }
    }
}
