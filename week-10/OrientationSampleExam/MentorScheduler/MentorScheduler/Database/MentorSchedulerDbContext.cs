using MentorScheduler.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MentorScheduler.Database
{
    public class MentorSchedulerDbContext : DbContext
    {
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<GfaClass> Classes { get; set; }
        public MentorSchedulerDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // one-to-many
            modelBuilder.Entity<Mentor>()
                        // .HasOne(t => t.Class)
                        .HasOne<GfaClass>(c => c.Class)
                        .WithMany(m => m.Mentors)
                        .HasForeignKey(c => c.ClassId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
