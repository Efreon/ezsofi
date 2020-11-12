using MentorScheduler.Database;
using MentorScheduler.Models.Entities;
using MentorScheduler.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentorScheduler.Models.Services
{
    public class MentorService :IMentorService
    {
        #region Properties
        private readonly MentorSchedulerDbContext dbContext;
        
        public Mentor ActualMentor { get; set; }
        public List<Mentor> Mentors { get; set; }
        #endregion

        #region Constructor
        public MentorService (MentorSchedulerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Methods
        public List<Mentor> AllMentors()
        {
            return dbContext.Mentors.ToList();
        }

        public bool FindMentor(string mentorName)
        {
            var mentor = dbContext.Mentors.FirstOrDefault(mentor => mentor.MentorName == mentorName);
            return mentor != null;
        }
        //public void NewMentor(string mentorName, Class gfaClass)
        //{
        //    dbContext.Mentors.Add()
        //}
        #endregion
    }
}
