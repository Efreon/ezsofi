using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Models.Services
{
    public class AssigneeServices : IAssigneeServices
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
