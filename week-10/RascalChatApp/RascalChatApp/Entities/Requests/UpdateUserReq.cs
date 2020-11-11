using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RascalChatApp.Entities
{
    public class UpdateUserReq
    {
        public string ApiKey { get; set; }
        public string UserName { get; set; }
        public string AvatarUrl { get; set; }

        public UpdateUserReq(string userName, string avatarUrl)
        {
            UserName = userName;
            AvatarUrl = avatarUrl;
        }
    }
}
