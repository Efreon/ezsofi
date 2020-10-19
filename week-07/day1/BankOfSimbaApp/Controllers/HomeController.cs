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
        [HttpGet("HTMLception")]
        public IActionResult HTMLception()
        {
            string text = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";

        }
        */
        [HttpGet("accounts")]
        public IActionResult Accounts()
        {
            var accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Nala", 1500, "lion"));
            accounts.Add(new BankAccount("Timon", 250, "meerkat"));
            accounts.Add(new BankAccount("Rafiki", 500, "mandrill"));
            accounts.Add(new BankAccount("Nala", 500, "lion"));

            var model = new AccountsViewModel(accounts);

            return View(model);
        }
    }
}
