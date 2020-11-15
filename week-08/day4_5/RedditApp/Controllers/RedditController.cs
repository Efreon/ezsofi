using Microsoft.AspNetCore.Mvc;
using RedditApp.Database;
using RedditApp.Entities;
using RedditApp.Models.Interfaces;
using RedditApp.Models.ViewModels;
using System.Linq;

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
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Login");
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
            return View("UserHome", new UserPostViewModel(userServices.FindUser(id), userServices.AllUser(), postService.AllPosts()));
        }
        [HttpPost("userhome/upvote")]
        public IActionResult UpVote(double userid, double postid)
        {
            postService.UpVote(userid, postid);
            return RedirectToAction("UserHome", "Reddit", new { UserId = userid });
            // return View("UserHome");
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
                return RedirectToAction("UserHome", "Reddit", new { userid = currentUser.UserId});
            }
            else
            {
                return View("LoginFailed");
            }  
        }
        [HttpGet("userhome")]
        public IActionResult UserHome(double userid)
        {
            var allPosts = postService.AllPosts();
            var allUser = userServices.AllUser();
            var currentUser = userServices.FindUser(userid);
            return View("UserHome", new UserPostViewModel(currentUser, allUser, allPosts));
        }
        #endregion
    }
}
