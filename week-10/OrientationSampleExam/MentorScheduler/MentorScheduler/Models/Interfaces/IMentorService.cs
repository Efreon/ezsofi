using MentorScheduler.Models.Entities;
using System.Collections.Generic;

namespace MentorScheduler.Models.Interfaces
{
    public interface IMentorService
    {
        public List<Mentor> AllMentors();
    }
}
