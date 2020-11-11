using RascalChatApp.Entities.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RascalChatApp.Models.ViewModels
{
    public class UpdateViewModel
    {
        public UpdateUserResp UserUpdates { get; set; }

        public UpdateViewModel()
        {

        }
        public UpdateViewModel(UpdateUserResp userUpdates)
        {
            UserUpdates = userUpdates;
        }
    }
}
