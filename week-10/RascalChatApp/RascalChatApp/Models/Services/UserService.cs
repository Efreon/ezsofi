using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RascalChatApp.Entities;
using RascalChatApp.Models.Interfaces;
using System.Net.Http;
using System.Text;
using System.Net.Http.Json;
using System;
using System.Net;

namespace RascalChatApp.Models.Services
{
    public class UserService : IUserService
    {
        public HttpClient client;
        public UserService([FromServices] IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("apiKey", "myValue");
            client.BaseAddress = new Uri("https://rascals-chat.herokuapp.com/api/user/");
        }

        public User Register(User user)
        {
            var sentInfo = JsonConvert.SerializeObject(user);
            var requestJson = new StringContent(sentInfo, Encoding.UTF8, "application/json");

            var response = client.PostAsync("register", requestJson).Result;
            var responseInfo = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<User>(responseInfo);
        }

        public User Login(string login, string password)
        {
            var sentInfo = JsonConvert.SerializeObject(new User(login, password));
            var requestBody = new StringContent(sentInfo, Encoding.UTF8, "application/json");

            var response = client.PostAsync("login", requestBody).Result;

            var responseContent = JsonConvert.DeserializeObject<User>(response.Content.ReadAsStringAsync().Result);
            return responseContent;
        }
    }
}
