using RascalChatApp.Entities;

namespace RascalChatApp.Models.Interfaces
{
    public interface IUserService
    {
        public User Register(User user);
        public User Login(string login, string password);

    }
}
