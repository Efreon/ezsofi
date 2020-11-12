using MentorScheduler.Models.Entities;
using System.Collections.Generic;

namespace MentorScheduler.Models.Interfaces
{
    public interface IClassService
    {
        public void InitialClasses();
        public List<GfaClass> AllClasses();
    }
}
