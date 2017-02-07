using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoWebAPIa.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebAPIa.API
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {

        static List<Product> _products = new List<Product>
        {
            new Product(1, "Milk", 2.33m),
            new Product(2, "Cheese", 5.44m),
            new Product(3, "Apples", 2.50m),
        };

        // decorate to specify that next command is a Get
        //[HttpGet]
        //public string Get()
        //{

        //    return "I don't have a favorite thing about programming anymore!";

        //}

        //// GET: api/values
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            Product prodToReturn = null;
            foreach (Product prod in _products)
            {
                if (prod.Id == id)
                {
                    prodToReturn = prod;
                }
            }
            return prodToReturn;
        }
        //// GET api/value/S
        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var product = _products.Find(p => p.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(product);
        //    }
        //}

        //// POST api/values
        //[HttpPost]
        //public IActionResult Post([FromBody] Product product)
        //{
        //    _products.Add(product);
        //    return Created("/products/" + product.Id.product);
        //}
    }
}
