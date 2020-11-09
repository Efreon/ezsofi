using RascalChatApp.Database;
using RascalChatApp.Entities;
using RascalChatApp.Models.Interfaces;
using System.Linq;

namespace RascalChatApp.Models.Services
{
    public class UserService : IUserService
    {
        private readonly ChatDbContext dbContext;
        public UserService(ChatDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void RegisterUser(string loginName, string password)
        {
            dbContext.Users.Add(new User(loginName, password));
            dbContext.SaveChanges();
        }
        public User FindUser(string loginName, string password)
        {
            return dbContext.Users.FirstOrDefault(u => u.LoginName == loginName && u.Password == password);
        }
    }
}
