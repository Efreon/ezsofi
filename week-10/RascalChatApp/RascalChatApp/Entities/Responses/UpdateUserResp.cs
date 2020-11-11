using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RascalChatApp.Entities.Responses
{
    public class UpdateUserResp
    {
        public string UserName { get; set; }
        public double UserId { get; set; }
    }
}
