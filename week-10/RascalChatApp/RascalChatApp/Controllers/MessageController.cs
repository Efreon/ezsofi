using Microsoft.AspNetCore.Mvc;
using RascalChatApp.Entities.Requests;
using RascalChatApp.Models.Interfaces;

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
        public IActionResult SendMessage(string content)
        {
            messageService.SendMsg(new SendMessageRequest(content));
            return View("Message");
        }
    }
}
