using RedditApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Models.ViewModels
{
    public class UserViewModel
    {
        public User CurrentUser { get; set; }
        public UserViewModel(User user)
        {
            CurrentUser = user;
        }
        public UserViewModel()
        {

        }
    }
}
