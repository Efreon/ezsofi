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
    [Route("")]
    public class HomeController : Controller
    {
        public ItemService service { get; set; }
        public HomeController()
        {
            service = new ItemService();
        }
        [HttpGet("webshop")]
        public IActionResult Items()
        {
            var shopItems = service.ReadAllItemsFromFile();
            var model = new ItemViewModel(shopItems);
            return View(model);
        }
        [HttpGet("cheapest-first")]
        public IActionResult ItemsSortedCheapest()
        {
            var shopItems = service.ItemsSortedPrice();
            var model = new ItemViewModel(shopItems);
            return View("Items", model);
        }
        [HttpGet("only-available")]
        public IActionResult ItemsOnlyAvailable()
        {
            var shopItems = service.ItemsOnlyAvailable();
            var model = new ItemViewModel(shopItems);
            return View("Items", model);
        }
        [HttpGet("contains-nike")]
        public IActionResult ItemsContainsNike()
        {
            var shopItems = service.ItemsContainsNike();
            var model = new ItemViewModel(shopItems);
            return View("Items", model);
        }
        [HttpPost("search")]
        public IActionResult Search(string search)
        {
            var shopItems = service.Search(search);
            var model = new ItemViewModel(shopItems);
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

        [HttpGet("more-filters")]
        public IActionResult MoreFilters()
        {
            var shopItems = service.ReadAllItemsFromFile();
            var model = new ItemViewModel(shopItems);
            return View(model);
        }

        [HttpGet("filter-by-type/{type}")]
        public IActionResult FilterType([FromRoute] string type)
        {
            var shopItems = service.FilterType(type);
            var model = new ItemViewModel(shopItems);
            return View(model);
        }

        // prices in euro //
        [HttpGet("price-in-euro")]
        public IActionResult PriceEuro()
        {
            var shopItems = service.PriceEuro();
            var model = new ItemViewModel(shopItems);
            return View(model);
        }

        // prices in original currency //
        [HttpGet("/price-in-original")]
        public IActionResult PriceOriginal()
        {
            var shopItems = service.PriceEuro();    
            var model = new ItemViewModel(shopItems);
            return RedirectToAction("MoreFilters");
        }

        // filter by price//
        [HttpPost("/filter-by-price")]
        public IActionResult FilterPrice(string how, int price)
        {
            var shopItems = service.FilterPrice(how, price);
            var model = new ItemViewModel(shopItems);
            return View("MoreFilters", model);
        }

    }
}
