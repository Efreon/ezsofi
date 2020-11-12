using MentorScheduler.Database;
using MentorScheduler.Models.Entities;
using MentorScheduler.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
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
        public Mentor FindMentorId(long mentorId)
        {
            var mentor = dbContext.Mentors
                                          .Include("Class")
                                          .FirstOrDefault(mentor => mentor.MentorId == mentorId)
                                          ; 
            return mentor;
        }
        public bool CheckMentorId(long mentorId)
        {
            var mentor = dbContext.Mentors.FirstOrDefault(mentor => mentor.MentorId == mentorId);
            return mentor !=null;
        }
        public Mentor NewMentor(string mentorName, GfaClass gfaClass)
        {
            var mentor = new Mentor(mentorName, gfaClass);
            dbContext.Mentors.Add(mentor);
            dbContext.SaveChanges();
            return mentor;
        }
        public List<MentorName> FilterMentors(string className)
        {
            var MentorNames = new List<MentorName>();

            var names =  dbContext.Mentors.Where(c => c.Class.ClassName == className)
                                    .Select(m => m.MentorName)
                                    .ToList();

            foreach (var name in names)
            {
                MentorNames.Add(new MentorName(name));
            }
            return MentorNames;
        }

        public long UpdateMentorResult(string name, string className, long mentorId)
        {

            var mentor = FindMentorId(mentorId);
            var egfclass = dbContext.Classes.FirstOrDefault(c => c.ClassName == className);

            if (mentor == null)
            {
                return 404;
            }
            else if(egfclass == null)
            {
                return 400;
            }
            else
            {
                mentor.MentorName = name;
                mentor.ClassId = egfclass.ClassId;
                return 200;
            }
        }
        public void DeleteMentor(long mentorId)
        {
            dbContext.Remove(dbContext.Mentors.FirstOrDefault(m => m.MentorId == mentorId));
            dbContext.SaveChanges();
        }

        #endregion
    }
}
