using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Data;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {

        [HttpGet("list")]
        public IActionResult List()
        {
            return View();
        }
    }
}
