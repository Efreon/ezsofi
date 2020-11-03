using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using RESTApiWs.Models;
using RESTApiWs.Services;

namespace RESTApiWs.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        private IAPIService apiService { get; set; }
        public HomeController(IAPIService apiService)
        {
            this.apiService = apiService;
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
                return new JsonResult(new { received = input, result = 2 * input });
            }
            else
            {
                return new JsonResult(new { error = "Please provide an input!" });
            }
        }

        // GET /greeter
        [HttpGet("greeter")]
        public ActionResult Greeter(string name, string title)
        {
            if (String.IsNullOrEmpty(name) && String.IsNullOrEmpty(title))
            {
                return BadRequest(new { error = "Please provide a name and a title!" });
            }
            else if (String.IsNullOrEmpty(name))
            {
                return BadRequest(new { error = "Please provide a name!" });
            }
            else if (String.IsNullOrEmpty(title))
            {
                return BadRequest(new { error = "Please provide a title!" });
            }
            else
            {
                return new JsonResult(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }
        [HttpGet("appenda/{appendable}")]
        public ActionResult AppendA(string appendable)
        {
            if (!String.IsNullOrEmpty(appendable))
            {
                return new JsonResult(new { appended = appendable + "a" });
            }
            else
            {
                return BadRequest();
            }

        }
        [HttpPost("dountil/{operation}")]
        public ActionResult DoUntil(string operation, [FromBody] BodyData data )
        {
            if (data.Until.HasValue && operation == "sum")
            {
                return new JsonResult(new { result = apiService.Sum((int)data.Until) });
            }
            else if (data.Until.HasValue && operation == "factor")
            {
                return new JsonResult(new { result = apiService.Factorial((int)data.Until) });
            }
            else
            {
                return StatusCode(400, new { error = "Please provide a number!" });
            }
        }
    }
}
