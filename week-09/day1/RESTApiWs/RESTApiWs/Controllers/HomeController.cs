using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTApiWs.Models;
using RESTApiWs.Services;

namespace RESTApiWs.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        public APIService ApiService { get; set; }
        public HomeController(APIService apiService)
        {
            ApiService = apiService;
        }

        public IActionResult Index()
        {
            return File("Index", "text/html");
        }

        // GET /doubling?input=5
        [HttpGet("doubling")]
        public ActionResult Doubling(int? input)
        {
            if (input.HasValue)
            {
                return Json(new { received = input, result = 2 * input });
            }
            else
            {
                return Json(new { error = "Please provide an input" });
            }
        }
    }
}
