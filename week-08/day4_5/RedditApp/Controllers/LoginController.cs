using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditApp.Entities;
using RedditApp.Models.Interfaces;

namespace RedditApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginServices loginService;
        public LoginController(ILoginServices loginService)
        {
            this.loginService = loginService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("createuser")]
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost("createuser")]
        public IActionResult CreateUser(string username, string pwd)
        {
            loginService.CreateUser(new User(username, pwd));
            return View("LoginPage");
        }
    }
}
