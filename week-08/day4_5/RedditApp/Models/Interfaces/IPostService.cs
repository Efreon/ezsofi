using RedditApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Models.Interfaces
{
    public interface IPostService
    {
        public void NewPost(Post post);
        public Post FindPost(string title, string url);
        public List<Post> AllPosts();
    }
}
