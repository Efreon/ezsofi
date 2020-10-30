using RedditApp.Database;
using RedditApp.Entities;
using RedditApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Models.Services
{
    public class UserServices :IUserServices
    {
        private readonly RedditDbContext dbContext;
        public List<User> Users { get; set; }
        public User CurrentUser { get; set; }
        public UserServices(RedditDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateUser(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
        }
        public User Login(string username, string pwd)
        {
            CurrentUser = dbContext.Users.FirstOrDefault(i => i.UserName == username && i.UserPassword == pwd);
            return CurrentUser;
        }
        public User FindUser(double id)
        {
            return dbContext.Users.FirstOrDefault(i => i.UserId == id);
        }
        public List<User> AllUser()
        {
            return dbContext.Users.ToList();
        }
    }
}
