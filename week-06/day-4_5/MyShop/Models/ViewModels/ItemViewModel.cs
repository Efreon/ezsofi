using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models.ViewModels
{
    public class ItemViewModel
    {
        public ShopItem MyItem { get; set; }
        public List<ShopItem> ShopItems { get; set; }
        public ItemViewModel(ShopItem myItem, List<ShopItem> shopItems)
        {
            MyItem = myItem;
            ShopItems = shopItems;
        }
    }
}
