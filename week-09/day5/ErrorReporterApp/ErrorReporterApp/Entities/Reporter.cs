using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ErrorReporterApp.Entities
{
    public class Reporter
    {
        [Key]
        public long ReporterId { get; set; }
        [Required]
        public string ReporterName { get; set; }

        //navigation property
        public List<Ticket> Tickets{ get; set; }
        public Reporter()
        {
            Tickets = new List<Ticket>();
        }
        public Reporter(string name)
        {
            ReporterName = name;
        }
    }
}
