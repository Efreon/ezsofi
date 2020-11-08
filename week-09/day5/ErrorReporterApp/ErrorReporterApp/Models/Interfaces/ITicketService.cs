using ErrorReporterApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorReporterApp.Models.Interfaces
{
    public interface ITicketService
    {
        public void NewTicket(string manufacturer, long serialNumber, string description, Reporter reporter);
        public List<Ticket> AllTickets();
        public void DeleteTicket(long id);
        public List<Ticket> FilterQuery(string manufacturer, string reporter);
    }
}
