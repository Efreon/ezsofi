using Microsoft.AspNetCore.Mvc;
using RascalChatApp.Entities.Requests;
using RascalChatApp.Models.Interfaces;
using RascalChatApp.Models.ViewModels;

namespace RascalChatApp.Controllers
{
    public class MessageController : Controller
    {
        private readonly IMessageService messageService;
        public MessageController(IMessageService messageService)
        {
            this.messageService = messageService;
        }

        [HttpPost("message")]
        public IActionResult SendMessage(int channelId, string channelSecret, string content)
        {
            var sentMessage = messageService.SendMsg(new SendMessageRequest(channelId, channelSecret, content));
            return View("Message", sentMessage);
        }
    }
}
