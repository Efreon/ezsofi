using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace MyShop.Models
{
    public class ShopItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string PriceCzk { get; set; }
        public double QuantityOfStock { get; set; }
        public string Type { get; set; }
        public string PriceEur { get; set; }

        public ShopItem(string name, string description, double price, double quantity, string type)
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityOfStock = quantity;
            PriceCzk = string.Format("{0:N2} Kc", price);
            PriceEur = string.Format("{0:N2} €", price*0.038);
            Type = type;
        }
        public ShopItem()
        {

        }
    }
}
