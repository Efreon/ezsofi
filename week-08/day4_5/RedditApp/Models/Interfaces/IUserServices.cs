using RedditApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Models.Interfaces
{
    public interface IUserServices
    {
        public void CreateUser(User user);
        public User Login(string username, string pwd);
        public User FindUser(double id);
        public List<User> AllUser();
    }
}
