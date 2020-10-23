using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClubApplication.Models.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using FoxClubApplication.Models;
using FoxClubApplication.Models.Services;
using FoxClubApplication.Models.ViewModels;

namespace FoxClubApplication.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public IFoxServices service;
        public HomeController(IFoxServices service)
        {
            this.service = service;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet("actualfox")]
        //public IActionResult Index(string name)
        //{
        //    return View(service.GetCurrentFox(name));
        //}

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult Index(string name)
        {
            service.AddFox(new Fox(name));
            return RedirectToAction("Information", new { Name = name });
        }

        [HttpGet("information")]
        public IActionResult Information(string name)
        {
            var currentfox = service.GetCurrentFox(name);
            return View(new FoxViewModel(currentfox));
        }
        [HttpGet("nutritionStore")]
        public IActionResult NutritionStore([FromQuery(Name = "name")] string name)
        {
            return View();
        }
    }
}
