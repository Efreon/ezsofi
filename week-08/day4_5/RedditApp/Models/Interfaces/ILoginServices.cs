using RedditApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Models.Interfaces
{
    public interface ILoginServices
    {
        void CreateUser(User user);
    }
}
