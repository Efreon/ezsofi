using ErrorReporterApp.Database;
using ErrorReporterApp.Entities;
using ErrorReporterApp.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public void DeleteTicket(long id)
        {
            dbContext.Remove(dbContext.Tickets.FirstOrDefault(a => a.TicketId == id));
            dbContext.SaveChanges();
        }
        //public List<Ticket> FilterQuery(string manufacturer, string reporter)
        //{
        //    return dbContext.Tickets.Where(t => t.Manufacturer == manufacturer || t.Reporter.ReporterName == reporter)
        //                            .ToList();
        //}
        public List<Ticket> FilterQuery(string manufacturer, string reporter)
        {

            var filteredTickets =  dbContext.Tickets.Where(t => t.Manufacturer == manufacturer || t.Reporter.ReporterName == reporter)
                                    .ToList();
            return filteredTickets;
        }

    }
}
