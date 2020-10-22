using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsefulUtilities.Services;
using UsefulUtilities.Interfaces;
using UsefulUtilities.Models.ViewModels;

namespace UsefulUtilities.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public IUtilityService service;
        public HomeController(IUtilityService service)
        {
            this.service = service;
        }
        [HttpGet("useful")]
        public IActionResult Index()
        {
            // stores the links to the utility pages
            return View();
        }
       
        [HttpGet("useful/colored")]
        public IActionResult ColoredView()
        {
            // returns randomly colored page
            var model = new ColoredViewModel(service.RandomColor());
            return View(model);
        }
        
        [HttpGet("useful/email")]
        public IActionResult EmailView(string email)
        {
            var model = new EmailViewModel(service.ValidateEmail(email));
            return View(model);
        }
        /*
        [HttpGet("ceasar")]
        public IActionResult Index()
        {
            return View();
        }
        */

    }
}
