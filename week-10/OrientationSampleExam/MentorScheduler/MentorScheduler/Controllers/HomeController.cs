using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MentorScheduler.Models.Interfaces;
using MentorScheduler.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MentorScheduler.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly IMentorService mentorService;
        private readonly IClassService classService;
        public HomeController(IMentorService mentorService, IClassService classService)
        {
            this.mentorService = mentorService;
            this.classService = classService;
        }
        [HttpGet("/")]
        public IActionResult Index()
        {
            // classService.InitialClasses();
            return View( "Index", new SchedulerViewModel(mentorService.AllMentors(), classService.AllClasses()));
        }
    }
}
