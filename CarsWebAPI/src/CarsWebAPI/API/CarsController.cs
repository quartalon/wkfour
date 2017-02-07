using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using CarsWebAPI.Services;
using CarsWebAPI.Models;


// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CarsWebAPI.API
{
    [Route("api/[controller]")]
    public class CarsController : Controller
    {

        private static List<Car> _cars = new List<Car>
        {
            new Car
            {
                Nick = "Green Jellybean",
                Year = 2003,
                Make = "BMW",
                Model = "MINI Cooper S",
                Id = 1,
                FullDescription = "This MINI Cooper S is great for the city. Maxi in its ability to induce smiles, mini in its price. A resource-saving runabout for the rabid.",
                //LearnMore = "http://www.miniusa.com/content/miniusa/en/why-mini/why-mini/over-50-years-of-motoring.html",
                ImageUrl = "http://images.rottentomatoes.com/images/features/cars/32.jpg"
            },
            new Car
            {
                Nick = "Beetle",
                Year = 1963,
                Make = "Volkswagen",
                Model = "Model 117 VW Type 1",
                Id = 2,
                FullDescription = "Its shape is among the most distinctive on the road; surprisingly, the Beetle is as fun to drive as it looks.",
                //LearnMore = "http://www.vsvwa.freeservers.com/bughist2.html",
                ImageUrl = "http://images.rottentomatoes.com/images/features/cars/02.jpg"
            },
            new Car
            {
                Nick = "Cruella",
                Year = 1964,
                Make = "Cadillac",
                Model = "Deville Convertible",
                Id = 3,
                FullDescription = "On the road, the Cadillac Deville displays plenty of power for quick passing maneuvers and effortless high-speed cruising.",
                //LearnMore = "https://en.wikipedia.org/wiki/Cadillac_de_Ville_series",
                ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRLit5CKhNOc3kLW1phtbSBFACaux5g6dmyF2sY492D1slhy5iV"
            },
            new Car
            {
                Nick = "Eleanor",
                Year = 1973,
                Make = "Ford",
                Model = "Mustang Mach 1",
                Id = 4,
                FullDescription = "The Ford Mustang Mach 1 is a performance-oriented option package of the Ford Mustang, originally introduced in August 1968.",
                //LearnMore = "https://en.wikipedia.org/wiki/Ford_Mustang_Mach_1",
                ImageUrl = "http://images.rottentomatoes.com/images/features/cars/41.jpg"
            },
            new Car
            {
                Nick = "Bumblebee",
                Year = 1967,
                Id = 5,
                Make = "Chevrolet",
                Model = "Camaro SS",
                FullDescription = "The RS was an appearance package, The SS performance package consisted of a 350 or 396 cu in V8 engine and chassis upgrades for better handling and to deal with the additional power.",
                //LearnMore = "https://en.wikipedia.org/wiki/Chevrolet_Camaro_(first_generation)",
                ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQj5NJ_UviO_g1Pp75j6LLz8ZLdc8g9q-rcyH6zaBqJKu5K6pY_nw"
            }
        };
        [HttpGet]
        public IEnumerable<Car> ListCars()
        {
            return _cars;
        }

        [HttpGet("{id}")]
        public Car Get(int id)
        {
            Car cToReturn = null;
            foreach (Car c in _cars)
            {
                if (c.Id == id)
                {
                    cToReturn = c;
                }
            }
            return cToReturn;
        }

            //public Car FindCar(int id)
            //{
            //    return _cars.Find(c => c.Id == id);
            //}

            //    private CarService _carService;

            //    public CarsController(CarService carService)
            //    {
            //        _carService = carService;
            //    }

            //    // GET: api/values
            //    [HttpGet]
            //    public IEnumerable<Car> Get()
            //    {
            //        return _carService.ListCars();
            //    }

            //    // GET api/values/5
            //    [HttpGet("{id}")]
            //    public Car Get(int id)
            //    {
            //        return _carService.FindCar(id);
            //    }
        
    }
}
