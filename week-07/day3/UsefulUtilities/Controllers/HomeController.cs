using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsefulUtilities.Services;

namespace UsefulUtilities.Controllers
{
    public class HomeController : Controller
    {
        public UtilityService service { get; set; }
        public HomeController()
        {
            service = new UtilityService();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
