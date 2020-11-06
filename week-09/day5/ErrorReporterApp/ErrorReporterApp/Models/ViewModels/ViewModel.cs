using ErrorReporterApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorReporterApp.Models.ViewModels
{
    public class ViewModel
    {
        public List<Ticket> Tickets { get; set; }
        public List<Reporter> Reporters { get; set; }
        public ViewModel(List<Ticket> tickets,  List<Reporter> reporters)
        {
            Tickets = tickets;
            Reporters = reporters;
        }
        public ViewModel()
        {

        }
    }
}
