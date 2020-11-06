using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ErrorReporterApp.Entities
{
    public class Ticket
    {
        [Key]
        public long TicketId { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public long SerialNumber { get; set; }
        [Required]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime TicketCreatedAt { get; set; }
        // navigation property
        public Reporter Reporter { get; set; }
        public long ReporterId { get; set; }

        public Ticket()
        {

        }
        public Ticket(string manufacturer, long serialNumber, string description, Reporter reporter)
        {
            Manufacturer = manufacturer;
            SerialNumber = serialNumber;
            Description = description;
            TicketCreatedAt = DateTime.Now;
            Reporter = reporter;
        }
    }
}
