using RascalChatApp.Entities;
using RascalChatApp.Entities.Requests;
using RascalChatApp.Entities.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RascalChatApp.Models.Interfaces
{
    public interface IMessageService
    {
        public Message SendMsg(SendMessageRequest messageRequest);
    }
}
