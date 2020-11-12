using MentorScheduler.Models.Entities;
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
            var mentors = mentorService.AllMentors();
            var classes = classService.AllClasses();
            return View("Index", new SchedulerViewModel(mentors, classes));
        }
        [HttpPost("/mentor")]
        public IActionResult NewMentor(string mentorName, long classId)
        {
            if (mentorService.FindMentor(mentorName))
            {
                return View("AddMentorFailed", mentorName);
            }
            else
            {
                var mentor = mentorService.NewMentor(mentorName, classService.FindClassId(classId));
                return Redirect($"mentor/{mentor.MentorId}");
            }
        }
        [HttpGet("mentor/{id}")]
        public IActionResult MentorInfos([FromRoute] long id)
        {
            var mentor = mentorService.FindMentorId(id);
            if (mentor != null)
            {
                return View("MentorInfos", new MentorViewModel(mentor));
            }
            else
            {
                return View("MentorInfoFailed");
            }
        }
        #region API 
        [HttpGet("api/mentors")]
        public IActionResult FilterMentors([FromQuery] string className)
        {
            if (!string.IsNullOrEmpty(className))
            {
                if (classService.FindClass(className))
                {
                    return Ok(new { name = mentorService.FilterMentors(className)});
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("api/mentors/{mentorId}")]
        public IActionResult UpdateMentor([FromRoute] long? mentorId, [FromBody] UpdateData json)
        {
            if (mentorId.HasValue)
            {
                var mentorUpdateResult = mentorService.UpdateMentorResult(json.Name,json.ClassName, (long)mentorId);
                switch (mentorUpdateResult)
                {
                    case 200: return Ok();
                    case 400: return BadRequest();
                    case 404: return NotFound();
                    default: return BadRequest();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("api/mentors/{mentorId}")]
        public IActionResult DeleteMentor([FromRoute] long? mentorId)
        {
            if (mentorId.HasValue)
            {
                if (mentorService.CheckMentorId((long)mentorId))
                {
                    mentorService.DeleteMentor((long)mentorId);
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }
        }
        #endregion
    }
}
