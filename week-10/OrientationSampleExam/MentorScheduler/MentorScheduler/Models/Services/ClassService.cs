using MentorScheduler.Database;
using MentorScheduler.Models.Entities;
using MentorScheduler.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MentorScheduler.Models.Services
{
    public class ClassService : IClassService
    {
        #region Properties
        private readonly MentorSchedulerDbContext dbContext;

        public List<GfaClass> Classes { get; set; }
        #endregion

        #region Constructor
        public ClassService(MentorSchedulerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        #endregion

        #region Methods
        public void InitialClasses()
        {
            dbContext.Classes.Add(new GfaClass("Latest"));
            dbContext.Classes.Add(new GfaClass("Saeg"));
            dbContext.Classes.Add(new GfaClass("Roadies"));
            dbContext.SaveChanges();
        }
        public List<GfaClass> AllClasses()
        {
            return dbContext.Classes.ToList();
        }
        public GfaClass FindClassId(long classId)
        {
            return dbContext.Classes.FirstOrDefault(c => c.ClassId == classId);
        }
        public bool FindClass(string className)
        {
            var gfaclass = dbContext.Classes.FirstOrDefault(c => c.ClassName == className);
            return gfaclass != null;
        }
        #endregion
    }
}