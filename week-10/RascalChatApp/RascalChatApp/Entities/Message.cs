using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RascalChatApp.Entities
{
    public class Message
    {
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public User Author { get; set; }
        public Message()
        {

        }
    }
}
