using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimbaApp.Models;
using BankOfSimbaApp.Models.ViewModels;
using BankOfSimbaApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimbaApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public AccountServices service {get; set;}

        public HomeController()
        {
            service = new AccountServices();
        }
        [HttpGet("show")]
        public IActionResult OneAccount()
        {
            var account = new BankAccount("Simba", 2000, "lion");
            var model = new OneAccountViewModel(account);

            return View(model);
        }
        /*
        [HttpGet("show")]
        public IActionResult Index()
        {
            // var account = new BankAccount("Simba", 2000, "lion");
            // return View(account);
            var accounts = service.ReadData();
            var model = new AccountViewModel(accounts);

            return View(model);
        }
         */
    }
}
