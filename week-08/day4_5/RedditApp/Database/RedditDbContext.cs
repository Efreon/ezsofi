using Microsoft.EntityFrameworkCore;
using RedditApp.Entities;

namespace RedditApp.Database
{
    public class RedditDbContext :DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public RedditDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
