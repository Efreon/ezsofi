using Microsoft.AspNetCore.Mvc;
using RedditApp.Database;
using RedditApp.Entities;
using RedditApp.Models.Interfaces;
using RedditApp.Models.ViewModels;

namespace RedditApp.Controllers
{
    [Route("")]
    public class RedditController : Controller
    {
        private readonly IUserServices userServices;
        private readonly IPostService postService;
        private readonly RedditDbContext dbContext;
        public RedditController(IUserServices userServices, IPostService postService, RedditDbContext dbContext)
        {
            this.userServices = userServices;
            this.postService = postService;
            this.dbContext = dbContext;
        }

        #region Post services
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("newpost")]
        public IActionResult NewPost()
        {
            return View();
        }
        [HttpPost("newpost")]
        public IActionResult NewPost(string title, string url, double id)
        {
            var currentPost = new Post(title, url);
            currentPost.User = userServices.FindUser(id);

            postService.NewPost(currentPost);
            return View("UserHome", new UserViewModel(userServices.FindUser(id)));
        }
        #endregion

        #region User services
        [HttpGet("createuser")]
        public IActionResult CreateUser()
        {
            return View();
        }
        [HttpPost("createuser")]
        public IActionResult CreateUser(string username, string pwd)
        {
            userServices.CreateUser(new User(username, pwd));
            return View("Login");
        }
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("userhome")]
        public IActionResult Login(string username, string pwd)
        {
            var currentUser = userServices.Login(username, pwd);
            if (currentUser != null)
            {
                return View("UserHome", new UserViewModel(currentUser));
            }
            else
            {
                return View("LoginFailed");
            }  
        }
        #endregion
    }
}
