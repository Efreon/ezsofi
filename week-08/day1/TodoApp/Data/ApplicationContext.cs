﻿using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Todo> Todos { get; set; } 
    }
}
