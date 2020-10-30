using RedditApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Models.ViewModels
{
    public class PostViewModel
    {
        public List<Post> Posts { get; set; }
        public Post Post { get; set; }
        public PostViewModel(List<Post> posts, Post post)
        {
            Posts = posts;
            Post = Post;
        }
        public PostViewModel()
        {

        }
    }
}
