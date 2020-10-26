using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Data;
using EntityFramework.Model;
using EntityFramework.Models.Services;
using EntityFramework.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        private readonly ITodoServices service;
        public TodoController(ITodoServices service)
        {
            this.service = service;
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            var todos = service.InitialTodoList();
            var model = new ListViewModel(todos);
            return View(model);
        }
    }
}
