using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
    }
}
