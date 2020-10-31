using RedditApp.Entities;
using System.Collections.Generic;

namespace RedditApp.Models.Interfaces
{
    public interface IPostService
    {
        public void NewPost(Post post);

        public List<Post> AllPosts();
        public void UpVote(double postid, double userid);
        // public Post FindPost(string title, string url);
    }
}
