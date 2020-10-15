using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Models
{
    public class ShopItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double QuantityOfStock { get; set; }

        public ShopItem(string name, string description, double price, double quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            QuantityOfStock = quantity;
        }
        public ShopItem()
        {

        }
        public override string ToString()
        {
            return $"{Name};{Description};{Price};{QuantityOfStock}";
        }

    }
}
