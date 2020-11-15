using Microsoft.AspNetCore.Mvc;

namespace MyApplication.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from the Controller!";
        }
    }
}
