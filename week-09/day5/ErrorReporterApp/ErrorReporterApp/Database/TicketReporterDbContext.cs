using ErrorReporterApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ErrorReporterApp.Database
{
    public class TicketReporterDbContext :DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Reporter> Reporters { get; set; }
        public TicketReporterDbContext(DbContextOptions options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one-to-many
            modelBuilder.Entity<Ticket>()
                        .HasOne<Reporter>(t => t.Reporter)
                        .WithMany(r => r.Tickets)
                        .HasForeignKey(t => t.ReporterId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
