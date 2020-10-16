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
 
        [HttpGet("items")]
        public IActionResult Items(ShopItem item)
        {
            var shopItems = service.ReadAllItemsFromFile();
            var model = new ItemViewModel(item, shopItems);
            return View(model);
        }
        [HttpGet("cheapest-first")]
        public IActionResult ItemsSortedCheapest(ShopItem item)
        {
            var shopItems = service.ItemsSortedPrice();
            var model = new ItemViewModel(item, shopItems);
            return View("Items", model);
        }
        [HttpGet("only-available")]
        public IActionResult ItemsOnlyAvailable(ShopItem item)
        {
            var shopItems = service.ItemsOnlyAvailable();
            var model = new ItemViewModel(item, shopItems);
            return View("Items", model);
        }
    }
}
