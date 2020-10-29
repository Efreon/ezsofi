using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Entities
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserPassword { get; set; }
        public List<Post> Posts { get; set; }
        public User(string name, string pwd)
        {
            UserName = name;
            UserPassword = pwd;   
        }
        public User()
        {

        }
    }
}
