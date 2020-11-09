using RascalChatApp.Entities;

namespace RascalChatApp.Models.Interfaces
{
    public interface IUserService
    {
        public void RegisterUser(string loginName, string password);
        public User FindUser(string loginName, string password);

    }
}
