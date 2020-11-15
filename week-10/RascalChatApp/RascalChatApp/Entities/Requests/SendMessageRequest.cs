using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RascalChatApp.Entities.Requests
{
    public class SendMessageRequest
    {
        public int ChannelId { get; set; }
        public string ChannelSecret { get; set; }
        public string Content { get; set; }
        public SendMessageRequest(string content)
        {
            
            Content = content;
        }
        public SendMessageRequest(int channelId, string channelSecret, string content)
        {
            ChannelId = channelId;
            ChannelSecret = channelSecret;
            Content = content;
        }
    }
}
