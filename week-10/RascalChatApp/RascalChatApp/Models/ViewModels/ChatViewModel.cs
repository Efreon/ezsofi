using Microsoft.Extensions.Configuration;
using RascalChatApp.Entities;
using System.Collections.Generic;
using System.Xml;

namespace RascalChatApp.Models.ViewModels
{
    public class ChatViewModel
    {
        public List<User> Users { get; set; }
        public ChatViewModel()
        {

        }
        public ChatViewModel(List<User> users)
        {
            Users = users;
        }
    }
}
