using ErrorReporterApp.Database;
using ErrorReporterApp.Entities;
using ErrorReporterApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorReporterApp.Models.Services
{
    public class ReporterService : IReporterService
    {
        private readonly TicketReporterDbContext dbContext;
        public List<Reporter> Reporters { get; set; }
        public Reporter ActualReporter { get; set; }
        public ReporterService(TicketReporterDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void CreateReporter()
        {
            // dbContext.Reporters.Add(reporter);
            dbContext.Reporters.Add(new Reporter("Szilvi"));
            dbContext.Reporters.Add(new Reporter("Kevi"));
            dbContext.Reporters.Add(new Reporter("Anna"));
            dbContext.Reporters.Add(new Reporter("Ádám"));
            dbContext.Reporters.Add(new Reporter("Marci"));
            dbContext.SaveChanges();
        }
        public List<Reporter> AllReporters()
        {
            return dbContext.Reporters.ToList();
        }
        public Reporter FindReporter(long reporterId)
        {
            ActualReporter = dbContext.Reporters.FirstOrDefault(r => r.ReporterId == reporterId);
            return ActualReporter;
        }
    }
}
