using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RascalChatApp.Entities;
using RascalChatApp.Models.Interfaces;
using System.Net.Http;
using System.Text;
using System.Net.Http.Json;

namespace RascalChatApp.Models.Services
{
    public class UserService : IUserService
    {
        private IHttpClientFactory clientFactory { get; set; }
        public HttpClient client;
        public string BaseAdress = "https://rascals-chat.herokuapp.com/api/user/";
        public UserService([FromServices] IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient();
        }
        public User Register(User user)
        {
            var sentInfo = JsonConvert.SerializeObject(user);
            var requestJson = new StringContent(sentInfo, Encoding.UTF8, "application/json");

            var response = client.PostAsync(BaseAdress+"register", requestJson).Result;
            var responseInfo = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<User>(responseInfo);
        }
        //public User FindUser(string login, string password)
        //{
        //    // return dbContext.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
        //}

        //Login
        public User Login(string login, string password)
        {
            var sentInfo = JsonConvert.SerializeObject(new User(login, password));
            var requestBody = new StringContent(sentInfo, Encoding.UTF8, "application/json");

            var response = client.PostAsync(BaseAdress + "login", requestBody).Result;
            var responseInfo = JsonConvert.DeserializeObject<User>(response.Content.ReadAsStringAsync().Result);
            return responseInfo;
        }

    }
}
