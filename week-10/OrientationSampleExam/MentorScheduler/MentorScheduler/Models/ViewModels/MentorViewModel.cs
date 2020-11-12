using MentorScheduler.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorScheduler.Models.ViewModels
{
    public class MentorViewModel
    {
        public Mentor ActualMentor { get; set; }
        public MentorViewModel(Mentor actualMentor)
        {
            ActualMentor = actualMentor;
        }
        public MentorViewModel()
        {

        }
    }
}
