using ErrorReporterApp.Entities;
using System.Collections.Generic;

namespace ErrorReporterApp.Models.Interfaces
{
    public interface IReporterService
    {
        public void CreateReporter();
        public Reporter FindReporter(long reporterId);
        public List<Reporter> AllReporters();
    }
}
