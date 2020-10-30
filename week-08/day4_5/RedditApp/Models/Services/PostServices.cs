using RedditApp.Database;
using RedditApp.Entities;
using RedditApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Models.Services
{
    public class PostServices : IPostService
    {
        private readonly RedditDbContext dbContext;
        public Post CurrenPost { get; set; }
        public PostServices(RedditDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void NewPost(Post post)
        {
            dbContext.Posts.Add(post);
            dbContext.SaveChanges();
        }
        public List<Post> AllPosts()
        {
            return dbContext.Posts.ToList();
        }
        public Post FindPost(string title, string url)
        {
            CurrenPost = dbContext.Posts.FirstOrDefault(i => i.PostTitle == title && i.PostUrl == url);
            return CurrenPost;
        }
    }
}
