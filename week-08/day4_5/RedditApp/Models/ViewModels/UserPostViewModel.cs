using RedditApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Models.ViewModels
{
    public class UserPostViewModel
    {
        public User CurrentUser { get; set; }
        public List<User> AllUsers { get; set; }
        public List<Post> AllPosts {get; set;}

        public UserPostViewModel(User user, List<User> allUsers, List<Post> allPosts)
        {
            CurrentUser = user;
            AllUsers = allUsers;
            AllPosts = allPosts;
        }
        public UserPostViewModel()
        {

        }
    }
}
