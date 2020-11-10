namespace RascalChatApp.Entities
{
    public class User
    {
        public double UserId { get; set; }
        public string Login { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ApiKey { get; set; }

        public User(string login, string password)
        {
            Login = login;
            UserName = login;
            Password = password;
        }

    }
}
