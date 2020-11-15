using RascalChatApp.Entities;

namespace RascalChatApp.Models.ViewModels
{
    public class MessageViewModel
    {
        public Message Message { get; set; }

        public MessageViewModel()
        {

        }
        public MessageViewModel(Message message)
        {
            Message = message;
        }
    }
}
