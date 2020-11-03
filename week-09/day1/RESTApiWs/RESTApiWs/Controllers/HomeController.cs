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
        private ILogService logService { get; set; }
        private IHunCamService hunCamService { get; set; }

        public HomeController(IAPIService apiService, ILogService logService, IHunCamService hunCamService)
        {
            this.apiService = apiService;
            this.logService = logService;
            this.hunCamService = hunCamService;
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
                logService.LogRequest("doubling", $"input = {input}");
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
                logService.LogRequest("greeter", $"name = {name}, title = {title}");
                return new JsonResult(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }
        
        [HttpGet("appenda/{appendable}")]
        public ActionResult AppendA(string appendable)
        {
            if (!String.IsNullOrEmpty(appendable))
            {
                logService.LogRequest("appenda", $"appendable = {appendable}");
                return new JsonResult(new { appended = appendable + "a" });
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpPost("dountil/{operation}")]
        public ActionResult DoUntil(string operation, [FromBody] BodyData data)
        {
            if (data.Until.HasValue && operation == "sum")
            {
                logService.LogRequest("dountil", $"operation = {operation}, data = {data}");
                return new JsonResult(new { result = apiService.Sum((int)data.Until) });
            }
            else if (data.Until.HasValue && operation == "factor")
            {
                logService.LogRequest("dountil", $"operation = {operation}, data = {data}");
                return new JsonResult(new { result = apiService.Factorial((int)data.Until) });
            }
            else
            {
                return StatusCode(400, new { error = "Please provide a number!" });
            }
        }
        
        [HttpPost("arrays")]
        public ActionResult ArrayHandler([FromBody] BodyData data)
        {

            if (data.What == "sum")
            {
                logService.LogRequest("arrays", $"what = {data.What}, data = {data.Numbers}");
                return new JsonResult(new { result = apiService.SumArray(data.Numbers) });
            }
            else if (data.What == "multiply")
            {
                logService.LogRequest("arrays", $"what = {data.What}, data = {data.Numbers}");
                return new JsonResult(new { results = apiService.MultiplyArray(data.Numbers) });
            }
            else if (data.What == "double")
            {
                logService.LogRequest("arrays", $"what = {data.What}, data = {data.Numbers}");
                return new JsonResult(new { result = apiService.DoubleArray(data.Numbers) });
            }
            else
            {
                return new JsonResult(new { error = "Please provide what to do with the numbers!" });
            }
        }

        [HttpGet("log")]
        public ActionResult GetLogs()
        {
            return new JsonResult(new { entries = logService.GetLogs(), entry_count = logService.GetLogs().Count });
        }

        [HttpPost("sith")]
        public ActionResult YodaSpeak([FromBody] BodyData data)
        {
            if (String.IsNullOrEmpty(data.Text))
            {
                return new JsonResult(new { error = "Feed me some text you have to, padawan young you are. Hmmm." });
            }
            else
            {
                return new JsonResult(new { sith_text = apiService.YodaSpeak(data.Text) });
            }
            
        }
        
        [HttpPost("translate")]
        public ActionResult HungarianCamellzer([FromBody] HunCam hunCamData)
        {
            if (String.IsNullOrEmpty(hunCamData.Text) || String.IsNullOrEmpty(hunCamData.Lang))
            {
                return new JsonResult(new { error = "I can't translate that!" });
            }
            else
            {
                return new JsonResult(new { translated = hunCamService.Camellizer(hunCamData.Text, hunCamData.Lang), lang = "teve" });
            }
        }
    }
}
