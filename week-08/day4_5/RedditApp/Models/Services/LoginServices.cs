using RedditApp.Database;
using RedditApp.Entities;
using RedditApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Models.Services
{
    public class LoginServices :ILoginServices
    {
        private readonly RedditDbContext dbContext;
        public LoginServices(RedditDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
    }
}
