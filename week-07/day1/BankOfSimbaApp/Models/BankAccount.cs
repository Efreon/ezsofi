using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimbaApp.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string AnimalType { get; set; }
        public string BalanceTwoDecimals { get; set; }
        public bool IsKing { get; set; }
        public bool IsGood { get; set; }

        public BankAccount(string name, double balance, string animalType, bool isKing, bool isGood)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            BalanceTwoDecimals = String.Format("{0:0.00}", balance) + " Zebra";
            IsKing = isKing;
            IsGood = IsGood;
        }
    }
}
