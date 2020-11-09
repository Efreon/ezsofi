using Microsoft.AspNetCore.Mvc;
using RascalChatApp.Models.Interfaces;

namespace RascalChatApp.Controllers
{
    [Route("api/user")]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Register");
        }
        [HttpPost("register")]
        public IActionResult RegisterUser(string loginName, string password)
        {
            userService.RegisterUser(loginName, password);
            return RedirectToAction("LoginView");
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost("login")]
        public IActionResult Login(string loginName, string password)
        {
            var currentUser = userService.FindUser(loginName, password);

            if (currentUser != null)
            {

                return View("Chat", currentUser);
            }
            else
            {
                return View("LoginFailed");
            }
        }
    }
}
