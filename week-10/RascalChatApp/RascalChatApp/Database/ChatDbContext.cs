using Microsoft.EntityFrameworkCore;
using RascalChatApp.Entities;

namespace RascalChatApp.Database
{
    public class ChatDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ChatDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
