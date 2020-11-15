using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RascalChatApp.Entities;
using RascalChatApp.Entities.Requests;
using RascalChatApp.Models.Interfaces;
using System;
using System.Net.Http;
using System.Text;

namespace RascalChatApp.Models.Services
{
    public class MessageService : IMessageService
    {
        public HttpClient client;
        public static string ApiKey { get; set; }
        public MessageService([FromServices] IHttpClientFactory clientFactory)
        {
            client = clientFactory.CreateClient();
            client.DefaultRequestHeaders.Add("ApiKey", UserService.ApiKey);
            // client.BaseAddress = new Uri("https://rascals-chat.herokuapp.com/api/");
        }
        public Message SendMsg(SendMessageRequest messageRequest)
        {
            var sentInfo = JsonConvert.SerializeObject(messageRequest);
            var requestJson = new StringContent(sentInfo, Encoding.UTF8, "application/json");

            var response = client.PostAsync("https://rascals-chat.herokuapp.com/api/message", requestJson).Result;
            var responseInfo = response.Content.ReadAsStringAsync().Result;

            var MessageSent = JsonConvert.DeserializeObject<Message>(responseInfo);

            return MessageSent;
        }
    }
}
