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
                                                                 Double.Parse(i.Split(";").ElementAt(3))))
                                        .ToList();
        }
        // only-available// 
        public List<ShopItem> ItemsOnlyAvailable()
        {
            return
            File.ReadAllLines(filePath).Where(i => Double.Parse(i.Split(";").ElementAt(3)) >0)
                                       .Select(i => new ShopItem(i.Split(";").ElementAt(0),
                                                                 i.Split(";").ElementAt(1),
                                                                 Double.Parse(i.Split(";").ElementAt(2)),
                                                                 Double.Parse(i.Split(";").ElementAt(3))))
                                        .ToList();
        }
        // cheapest-first//
        public List<ShopItem> ItemsSortedPrice()
        {
            return
            File.ReadAllLines(filePath).OrderBy(i => Double.Parse(i.Split(";").ElementAt(2)))
                                       .Select(i => new ShopItem(i.Split(";").ElementAt(0),
                                                                 i.Split(";").ElementAt(1),
                                                                 Double.Parse(i.Split(";").ElementAt(2)),
                                                                 Double.Parse(i.Split(";").ElementAt(3))))
                                        .ToList();
        }
        //contains-nike//
        public List<ShopItem> ItemsContainsNike()
        {
            return
            File.ReadAllLines(filePath).Where(i => i.Split(";").ElementAt(0).ToLower().Contains("nike") || i.Split(";").ElementAt(1).ToLower().Contains("nike"))
                                       .OrderBy(i => Double.Parse(i.Split(";").ElementAt(2)))
                                       .Select(i => new ShopItem(i.Split(";").ElementAt(0),
                                                                 i.Split(";").ElementAt(1),
                                                                 Double.Parse(i.Split(";").ElementAt(2)),
                                                                 Double.Parse(i.Split(";").ElementAt(3))))
                                        .ToList();
        }
        //average-stock//
        public double AverageStockPrice()
        {
            return
            File.ReadAllLines(filePath).Where(i => Double.Parse(i.Split(";").ElementAt(3)) > 0)
                                       .Select(i => Double.Parse(i.Split(";").ElementAt(3)))
                                       .Average();
        }
        public string MostExpensive()
        {
            return
            File.ReadAllLines(filePath).Where(i => Double.Parse(i.Split(";").ElementAt(2)) > 0)
                                       .OrderByDescending(i => Double.Parse(i.Split(";").ElementAt(2)))
                                       .Select(i => Double.Parse(i.Split(";").ElementAt(0)))
                                       .ToString();
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
