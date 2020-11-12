using MentorScheduler.Models.Entities;
using System.Collections.Generic;

namespace MentorScheduler.Models.Interfaces
{
    public interface IMentorService
    {
        public List<Mentor> AllMentors();
        public bool FindMentor(string mentorName);
        public Mentor NewMentor(string mentorName, GfaClass gfaClass);
        public Mentor FindMentorId(long mentorId);
        public List<MentorName> FilterMentors(string className);
        public bool CheckMentorId(long mentorId);
        public long UpdateMentorResult(string name, string className, long mentorId);
        public void DeleteMentor(long mentorId);
    }
}
