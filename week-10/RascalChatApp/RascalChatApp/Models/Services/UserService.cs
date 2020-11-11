using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RascalChatApp.Entities;
using RascalChatApp.Models.Interfaces;
using System.Net.Http;
using System.Text;
using System.Net.Http.Json;
using System;
using System.Net;
using RascalChatApp.Entities.Responses;

namespace RascalChatApp.Models.Services
{
    public class UserService : IUserService
    {
        public HttpClient client;
        public static string ApiKey { get; set; }
        public UserService([FromServices] IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("ApiKey", ApiKey);
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
            ApiKey = responseContent.ApiKey;

            return responseContent;
        }

        public UpdateUserResp Update(string userName, string avatarUrl)
        {

            var sentInfo = JsonConvert.SerializeObject(new UpdateUserReq(userName, avatarUrl));
            var requestBody = new StringContent(sentInfo, Encoding.UTF8, "application/json");

            var response = client.PostAsync("update", requestBody).Result;
            var updatedUser = JsonConvert.DeserializeObject<UpdateUserResp>(response.Content.ReadAsStringAsync().Result);

            return updatedUser;
        }
    }
}
