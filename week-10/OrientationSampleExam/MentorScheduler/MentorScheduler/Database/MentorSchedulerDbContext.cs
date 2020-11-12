using MentorScheduler.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MentorScheduler.Database
{
    public class MentorSchedulerDbContext : DbContext
    {
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Class> Classes { get; set; }
        public MentorSchedulerDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one-to-many
            modelBuilder.Entity<Mentor>()
                        .HasOne(t => t.Class)
                        .WithMany(r => r.Mentors)
                        .HasForeignKey(t => t.ClassId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
