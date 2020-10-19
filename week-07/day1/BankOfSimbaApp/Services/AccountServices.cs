using BankOfSimbaApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimbaApp.Services
{
    public class AccountServices
    {
        private readonly string filePath;
        // public List<BankAccount> AccountData;
        public AccountServices()
        {
            filePath = @"D:\greenfox\ezsofi\week-07\day1\BankOfSimbaApp\data\accounts.txt";
            EnsureFileExists();
        }
        public List<BankAccount> ReadData()
        {
            var AccountData = File.ReadAllLines(filePath).Select(i => new BankAccount(i.Split(";").ElementAt(0),
                                                                         Double.Parse(i.Split(";").ElementAt(1)),
                                                                                      i.Split(";").ElementAt(2)))
                                                         .ToList();
            return AccountData;
        }

        public void SaveAccount(BankAccount account)
        {
            File.AppendAllLines(filePath, new string[] { account.ToString() });
        }
        private void EnsureFileExists()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }
    }
}
