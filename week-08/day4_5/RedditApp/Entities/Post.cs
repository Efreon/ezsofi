using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Entities
{
    public class Post
    {
        [Key]
        public long PostId { get; set; }
        [Required]
        public string PostTitle { get; set; }
        [Required]
        public string PostUrl { get; set; }
        public double PostScore { get; set; }
        [DataType(DataType.Date)]
        public DateTime PostCreatedAt { get; set; }
        public Post()
        {

        }
        public Post(string title, string url, double score = 0)
        {
            PostTitle = title;
            PostUrl = url;
            PostCreatedAt = DateTime.Now;
            PostScore = score;
        }
    }
}
