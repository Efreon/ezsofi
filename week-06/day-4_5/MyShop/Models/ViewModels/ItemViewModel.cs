using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models.ViewModels
{
    public class ItemViewModel
    {
        public List<ShopItem> ShopItems { get; set; }
        public double StockQtyAvg { get; set; }
        public string ItemName { get; set; }

        public ItemViewModel(List<ShopItem> shopItems)
        {
            ShopItems = shopItems;
        }
        public ItemViewModel(double value)
        {
            StockQtyAvg = value;
        }
        public ItemViewModel(string mostExpensiveName)
        {
            ItemName = mostExpensiveName;
        }
    }
}
