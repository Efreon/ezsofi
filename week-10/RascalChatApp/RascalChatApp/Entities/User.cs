namespace RascalChatApp.Entities
{
    public class User
    {
        public double UserId { get; set; }
        public string LoginName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public User(string loginName, string password)
        {
            LoginName = loginName;
            UserName = loginName;
            Password = password;
        }

    }
}
