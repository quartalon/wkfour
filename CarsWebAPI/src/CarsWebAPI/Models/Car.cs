using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsWebAPI.Models
{
    public class Car
    {
        public string Nick { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Id { get; set; }

        public string FullDescription { get; set; }

        //public string LearnMore { get; set; }

        public string ImageUrl { get; set; }

        //public Car(string nick, int year, string make, string model, int id, string fullDescription, string learnMore, string imageUrl)
        //{
        //    Nick = nick;
        //    Year = Year;
        //    Make = make;
        //    Model = model;
        //    Id = id;
        //    FullDescription = fullDescription;
        //    LearnMore = learnMore;
        //    ImageUrl = imageUrl;

        //}

    }

}
