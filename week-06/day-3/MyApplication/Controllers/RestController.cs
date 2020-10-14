using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        [HttpGet("greeting")]
        public Greeting GreetName([FromQuery(Name = "name")] string name)
        {
            var greetObj = new Greeting(name);
            return greetObj;
        }
        //[HttpGet("greeting")]
        //public Greeting GreetName(long id, [FromQuery(Name = "name")] string name)
        //{
        //    var greetObj = new Greeting(id, name);
        //    return greetObj;
        //}

        //[HttpGet("greeting")]
        //public Greeting Greet()
        //{
        //    var greetObj = new Greeting(1, "Hello, World!");
        //    return greetObj;
        //}
    }
}
