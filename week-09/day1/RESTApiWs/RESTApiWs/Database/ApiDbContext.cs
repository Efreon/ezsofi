using Microsoft.EntityFrameworkCore;
using RESTApiWs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiWs.Database
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public ApiDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
