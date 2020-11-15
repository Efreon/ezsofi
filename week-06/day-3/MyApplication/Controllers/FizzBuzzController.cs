using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyApplication.Models;

namespace MyApplication.Controllers
{
    [Route("api")]
    public class FizzBuzzController : Controller
    {
        [HttpGet("fizzbuzz")]
        public IActionResult Index()
        {
            var model = new FizzBuzzCounter();

            return View(model);
        }
    }
}
