
using ErrorReporterApp.Entities;
using ErrorReporterApp.Models.Interfaces;
using ErrorReporterApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ErrorReporterApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly IReporterService reporterService;
        private readonly ITicketService ticketService;
        public HomeController(IReporterService reporterService, ITicketService ticketService)
        {
            this.reporterService = reporterService;
            this.ticketService = ticketService;
        }
        // Create new tickets //
        [HttpGet("")]
        public IActionResult Index()
        {
            // reporterService.CreateReporter();
            return View("Index", new ViewModel(ticketService.AllTickets(), reporterService.AllReporters()));
        }
        [HttpPost("report")]
        public IActionResult NewTicket(long reporterId, string manufacturer, long serialNumber, string description)
        {
            ticketService.NewTicket(manufacturer, serialNumber, description, reporterService.FindReporter(reporterId));
            // return RedirectToAction("list", new ViewModel(ticketService.AllTickets(), reporterService.AllReporters()));
            return RedirectToAction("List");
        }
        [HttpGet("list")]
        public IActionResult List()
        {
            return View("list", new ViewModel(ticketService.AllTickets(), reporterService.AllReporters()));
        }
    }
}
