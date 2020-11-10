using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RascalChatApp.Models.ViewModels
{
    public class RegisterFailedViewModel
    {
        public string Message { get; set; }
        public RegisterFailedViewModel()
        {
            Message = "Please sign up";
        }
        public RegisterFailedViewModel(string message)
        {
            Message = message;
        }
    }
}
