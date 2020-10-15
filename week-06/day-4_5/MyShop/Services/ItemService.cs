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
        //public void SaveItemToFile(ShopItem item)
        //{
        //    File.AppendAllLines(filePath, new string[] { item.ToString() });
        //}
        public List<ShopItem> ReadAllItemsFromFile()
        {
            return 
            File.ReadAllLines(filePath).Select(i => new ShopItem(i.Split(";").ElementAt(0),
                                                                 i.Split(";").ElementAt(1),
                                                                 Double.Parse(i.Split(";").ElementAt(2)), 
                                                                 Double.Parse(i.Split(";").ElementAt(3))))
                                        .ToList();
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
