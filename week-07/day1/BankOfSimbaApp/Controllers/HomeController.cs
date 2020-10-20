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
        // Showing one account //
        [HttpGet("show")]
        public IActionResult OneAccount()
        {
            var account = new BankAccount("Simba", 2000, "lion", false, false);
           // var model = new OneAccountViewModel(account);

            return View(account);
        }
        
        [HttpGet("HTMLception")]
        public IActionResult HTMLception()
        {

            var text = "This is an <em>HTML</em> text. <b>Enjoy yourself!</b>";
            //var text = new HTMLCeptionvIEWmODEL();
            return View("HTMLception",text);
        }
        
        [HttpGet("accounts")]
        public IActionResult Accounts()
        {
            //var accounts = new List<BankAccount>();
            //accounts.Add(new BankAccount("Nala", 1500, "lion", false, false));
            //accounts.Add(new BankAccount("Timon", 250, "meerkat", true, false));
            //accounts.Add(new BankAccount("Rafiki", 500, "mandrill", false, false));
            //accounts.Add(new BankAccount("Mufasa", 500, "lion", false, false));
            //accounts.Add(new BankAccount("Scar", 1870, "lion", false, true));
            var accounts = service.ReadData();
            var model = new AccountsViewModel(accounts);
            return View(model);
        }
        [HttpPost("addaccount")]
        public IActionResult AddAccount(BankAccount account)
        {
            service.AddAccount(account);
            return RedirectToAction("accounts");
        }
        [HttpPost("raisebalance")]
        public IActionResult RaiseBalance(string name)
        {
            var accounts = service.ReadData();
            foreach (var account in accounts)
            {
                if(account.Name.ToLower() == name.ToLower())
                {
                    account.RaiseBalance();
                }
            }
            service.UpdateData();
            return RedirectToAction("accounts");
        }
    }
}
