
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

        [HttpPost("complete/{id}")]
        // This endpoint should delete the specified ticket if the request's body contains "secret" : "voala"
        public IActionResult DeleteTicket([FromBody] BodyData json, [FromRoute] long? id)
        {
            if (id.HasValue && json.Secret == "voala")
            {
                ticketService.DeleteTicket((long)id);
                return Ok(new { message = $"Deleted ticket nr.{id}"});
            }
            else
            {
                return BadRequest(new { message = $"Can not delete the ticket nr. {id} . Secret is not voala"});
            }
        }
        [HttpGet("list/query")]
        public IActionResult FilterQuery([FromQuery] string manufacturer, [FromQuery] string reporter)
        {
            if (!string.IsNullOrEmpty(manufacturer) || !string.IsNullOrEmpty(reporter))
            {
                return Ok(new { result = "ok", tickets = ticketService.FilterQuery(manufacturer, reporter) });
            }
            else
            {
                return BadRequest(new { message = "Invalid input, can't return any tickets" });
            }
        }
    }
}
