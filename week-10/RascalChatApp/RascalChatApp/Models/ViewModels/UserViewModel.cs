using Microsoft.Extensions.Configuration;
using RascalChatApp.Entities;
using System.Collections.Generic;
using System.Xml;

namespace RascalChatApp.Models.ViewModels
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel()
        {

        }
        public UserViewModel(User user)
        {
            User = user;
        }
    }
}
