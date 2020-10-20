using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirtsApplication.NewFolder
{
    [Route("home")]
    public class HomeController : Controller
    {
        [HttpGet("index")]
        public IActionResult Index(string name)
        {
            var model = new Pirate(name, 25/*, PirateType.Captain*/);
            //var pirate = model.ToString();

            //return View("index", model);
            return View(model);
        }
        [HttpGet("pirate")]
        public Pirate GetPirate()
        {
            var model = new Pirate("Johnny", 25/*, PirateType.Captain*/);
            return model;
        }
    }
}
