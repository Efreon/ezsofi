using Microsoft.AspNetCore.Mvc;
using RascalChatApp.Entities;
using RascalChatApp.Models.Interfaces;
using RascalChatApp.Models.ViewModels;

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
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View("Register");
        }
        [HttpPost("register")]
        public IActionResult Register(string login, string password)
        {
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                var user = new User(login, password);
                var userResponse = userService.Register(user);
                var responseMessage = new { username = userResponse.UserName, userid = userResponse.UserId };
                return View("Login");
            }
            else
            {
                var message = !string.IsNullOrEmpty(login) ? "missing username, please provide" : "missing password, please provide";
                return View("Register");
            }
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost("login")]
        public IActionResult Login(string login, string password)
        {
            var currentUser = userService.Login(login, password);
            return View("Chat", new ChatViewModel(currentUser));
        }
    }
}
