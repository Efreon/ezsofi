using ErrorReporterApp.Database;
using ErrorReporterApp.Entities;
using ErrorReporterApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ErrorReporterApp.Models.Services
{
    public class TicketService : ITicketService
    {
        private readonly TicketReporterDbContext dbContext;
        public Ticket ActualTicket { get; set; }
        public List<Ticket> Tickets { get; set; }
        public TicketService(TicketReporterDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void NewTicket(string manufacturer, long serialNumber, string description, Reporter reporter)
        {
            dbContext.Tickets.Add(new Ticket(manufacturer, serialNumber,description, reporter ));
            dbContext.SaveChanges();
        }
        public List<Ticket> AllTickets()
        {
            return dbContext.Tickets.ToList();
        }
    }
}
