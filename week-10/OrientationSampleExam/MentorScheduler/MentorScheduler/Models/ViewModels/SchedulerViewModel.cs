using MentorScheduler.Models.Entities;
using System.Collections.Generic;

namespace MentorScheduler.Models.ViewModels
{
    public class SchedulerViewModel
    {
        public List<Mentor> Mentors { get; set; }
        public List<GfaClass> Classes { get; set; }
        public SchedulerViewModel(List<Mentor> mentors, List<GfaClass> classes)
        {
            Mentors = mentors;
            Classes = classes;
        }
        public SchedulerViewModel()
        {

        }
    }
}
