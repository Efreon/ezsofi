using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClubApplication.Models
{
    public class Fox
    {
        public string FoxName { get; set; }
        public List<string> KnownTricks { get; set; }
        public List<string> FoxFood { get; set; }
        public List<string> FoxDrink { get; set; }

        public Fox(string name)
        {
            FoxName = name;
            KnownTricks = new List<string>();
            FoxFood = new List<string> { "french fries"};
            FoxDrink = new List<string> { "green tea"};
        }
    }
}
