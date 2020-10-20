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
        private string filePath;
        public List<BankAccount> accountData;
        public AccountServices()
        {
            filePath = @"D:\greenfox\ezsofi\week-07\day1\BankOfSimbaApp\data\accounts.txt";
            EnsureFileExists();
        }

        //all items//
        public List<BankAccount> ReadData()
        {
            accountData = File.ReadAllLines(filePath).Select(i => new BankAccount(i.Split(";").ElementAt(0),
                                                                                  Double.Parse(i.Split(";").ElementAt(1)),
                                                                                  (i.Split(";").ElementAt(2)),
                                                                                  Boolean.Parse(i.Split(";").ElementAt(3)),
                                                                                  Boolean.Parse(i.Split(";").ElementAt(4))))
                                                      .ToList();
            return accountData;
        }
        // add new items //
        public void AddAccount(BankAccount account)
        {
            File.AppendAllLines(filePath, new string[] { account.ToString()});
        }
        // update data //
        public void UpdateData()
        {
            // accountData = ReadData();
            File.WriteAllText(filePath, "");
            foreach(var account in accountData)
            {
                AddAccount(account);
                //File.AppendAllLines(filePath, account.ToString());
            }
        }
        // check if the file exists //
        private void EnsureFileExists()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

    }
}
