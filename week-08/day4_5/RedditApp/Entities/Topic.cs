using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Entities
{
    public class Topic
    {
        [Key]
        public long TopicId { get; set; }
        [Required]
        public string TopicName { get; set; }
        public List<Post> Posts { get; set; }
        public Topic()
        {

        }
    }
}
