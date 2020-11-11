using RascalChatApp.Entities;
using RascalChatApp.Entities.Responses;

namespace RascalChatApp.Models.Interfaces
{
    public interface IUserService
    {
        public User Register(User user);
        public User Login(string login, string password);
        public UpdateUserResp Update(string userName, string avatarUrl);

    }
}
