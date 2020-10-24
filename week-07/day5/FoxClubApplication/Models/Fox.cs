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
        public string FoxFood { get; set; }
        public string FoxDrink { get; set; }

        public Fox(string name)
        {
            FoxName = name;
            KnownTricks = new List<string>();
            FoxFood ="french fries";
            FoxDrink = "green tea";
        }
    }
}
