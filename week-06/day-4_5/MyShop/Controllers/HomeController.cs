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
        [HttpGet("contains-nike")]
        public IActionResult ItemsContainsNike(ShopItem item)
        {
            var shopItems = service.ItemsContainsNike();
            var model = new ItemViewModel(item, shopItems);
            return View("Items", model);
        }
        [HttpPost("search")]
        public IActionResult Search(ShopItem item, /*[FromQuery(Name = "search")]*/ string search)
        {
            var shopItems = service.Search(search);
            var model = new ItemViewModel(item, shopItems);
            return View("Items", model);
        }
        [HttpGet("average-stock")]
        public IActionResult AverageStockPrice()
        {
            var averageValue = service.AverageStockPrice();
            var model = new ItemViewModel(averageValue);
            return View("averageQuantity", model);
        }
        [HttpGet("most-expensive")]
        public IActionResult MostExpensive()
        {
            var mostExpensive = service.MostExpensive();
            var model = new ItemViewModel(mostExpensive);
            return View("mostExpensive", model);
        }
    }
}
