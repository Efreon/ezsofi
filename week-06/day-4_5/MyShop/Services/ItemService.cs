using MyShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Services
{
    public class ItemService
    {
        private string filePath;
        public ItemService()
        {
            filePath = @"D:\greenfox\ezsofi\week-06\day-4_5\MyShop\Services\shopitems.txt";
        
            EnsureFileExists();
        }
        //all items//
        public List<ShopItem> ReadAllItemsFromFile()
        {
            return
            File.ReadAllLines(filePath).Select(i => new ShopItem(i.Split(";").ElementAt(0),
                                                                 i.Split(";").ElementAt(1),
                                                                 Double.Parse(i.Split(";").ElementAt(2)),
                                                                 Double.Parse(i.Split(";").ElementAt(3)),
                                                                 i.Split(";").ElementAt(4)))
                                        .ToList();
        }

        // only-available// 
        public List<ShopItem> ItemsOnlyAvailable()
        {
            var items = ReadAllItemsFromFile()
                .Where(i => i.QuantityOfStock > 0)
                .ToList();
            return items; 
        }

        // cheapest-first//
        public List<ShopItem> ItemsSortedPrice()
        {
            var items = ReadAllItemsFromFile()
                .OrderBy(i => i.Price)
                .ToList();
            return items;
        }

        //contains-nike//
        public List<ShopItem> ItemsContainsNike()
        {
            var items = ReadAllItemsFromFile()
                .Where(i => i.Name.ToLower().Contains("nike") || i.Description.ToLower().Contains("nike"))
                .ToList();
            return items;
        }

        //search//
        public List<ShopItem> Search(string search)
        {
            var items = ReadAllItemsFromFile()
                  .Where(i => i.Name.ToLower().Contains(search.ToLower()) || i.Description.ToLower().Contains(search.ToLower()))
                  .ToList();
            return items;
        }

        //average-stock//
        public double AverageStockPrice()
        {
            var avg = ReadAllItemsFromFile()
                .Where(i => i.Price > 0)
                .Select(i => i.Price)
                .Average();
            return avg;
        }

        //most-expensive//
        public string MostExpensive()
        {
            var highestPriceItem = ReadAllItemsFromFile()
                .Where(i => i.Price > 0)
                .OrderByDescending(i => i.Price)
                .Select(i => i.Name)
                .Take(1)
                .ToList()[0];
            return highestPriceItem;
        }

        //filter-by-type//
        public List<ShopItem> FilterType(string type)
        {
            var items = ReadAllItemsFromFile()
                .Where(i => i.Type.Replace(" ","" ).ToLower() == type.ToLower())
                .ToList();
            return items;
        }

        //price-in-euro//
        public List<ShopItem> PriceEuro()
        {
            var items = ReadAllItemsFromFile();
            return items;
        }

        // filter-by-price//
        public List<ShopItem> FilterPrice(string how, int price)
        {
            var items = ReadAllItemsFromFile();
            if(how == "above")
            {
                items = items
                .Where(i => i.Price > price)
                .ToList();
            }
            else if (how == "below")
            {
                items = items
                .Where(i => i.Price < price)
                .ToList();
            }
            else if (how == "exactly")
            {
                items = items
                .Where(i => i.Price == price)
                .ToList();
            }
            return items;
        }

        private void EnsureFileExists()
        {
            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

    }
}
