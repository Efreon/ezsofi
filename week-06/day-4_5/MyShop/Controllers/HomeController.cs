using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyShop.Models;
using MyShop.Models.ViewModels;
using MyShop.Services;

namespace MyShop.Controllers
{
    //[Route("webshop")]
    [Route("")]
    public class HomeController : Controller
    {
        public ItemService service { get; set; }
        public HomeController()
        {
            service = new ItemService();
        }
        public string Index()
        {
            return "Hello World";
        }
        // [HttpGet("items")]
        [HttpGet("")]
        public IActionResult Items(ShopItem item)
        {
            var shopItems = service.ReadAllItemsFromFile();
            var model = new ItemViewModel(item, shopItems);
            return View(model);
        }
        //[HttpPost("item")]
        //public IActionResult CreatItem(ShopItem item)
        //{
        //    return RedirectToAction("Items", item);
        //}
    }
}
