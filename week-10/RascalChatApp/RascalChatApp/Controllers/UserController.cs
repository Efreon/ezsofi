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

        #region Registration
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
                // var responseMessage = new { username = userResponse.UserName, userid = userResponse.UserId };
                return View("Login");
            }
            else
            {
                var responseMessage = !string.IsNullOrEmpty(login) ? "missing username, please provide" : "missing password, please provide";
                return View("RegisterFailed");
            }
        }
        #endregion
        
        #region Login
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login");
        }
        [HttpPost("login")]
        public IActionResult Login(string login, string password)
        {
            var currentUser = userService.Login(login, password);
            if (currentUser != null)
            {
                return View("Message", new UserViewModel(currentUser));
            }
            else
            {
                return View("LoginFailed");
            }
        }
        #endregion

        #region User Update
        [HttpGet("update")]
        public IActionResult Update()
        {
            return View("Update");
        }
        [HttpPost("update")]
        public IActionResult Update(string userName, string avatarUrl)
        {
            userService.Update(userName, avatarUrl);
            return View("UserUpdated");
        }
        #endregion

        #region LogOut
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            userService.Logout();
            return RedirectToAction("Login");
        }
        #endregion
    }
}
