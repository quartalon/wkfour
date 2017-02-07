using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebAPI.API
{
    // specify the name of the controller w/o the word controller, i.e. Products - Not ProductsController
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // decorate to specify that next command is a Get
        [HttpGet]
        public string Get()
        {

            return "hello, world!";

        }
    }
}
