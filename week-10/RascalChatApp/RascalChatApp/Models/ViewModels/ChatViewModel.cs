using Microsoft.Extensions.Configuration;
using RascalChatApp.Entities;
using System.Collections.Generic;
using System.Xml;

namespace RascalChatApp.Models.ViewModels
{
    public class ChatViewModel
    {
        public User User { get; set; }
        public ChatViewModel()
        {

        }
        public ChatViewModel(User user)
        {
            User = user;
        }
    }
}
