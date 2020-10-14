using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        public static int callCounter = 1;
        [HttpGet("greeting")]
        public IActionResult Greeting([FromQuery(Name = "name")] string name)
        {
            var greeting = new Greeting()
            {
                Name = name,
                Id = callCounter++
            };
            return View(greeting);
        }

        //[HttpGet("greeting")]
        //public IActionResult Greeting()
        //{
        //    var greeting = new Greeting()
        //    {
        //        Id = 1,
        //        Content = "from the model"
        //    };
        //    return View(greeting);
        //}
    }
}
