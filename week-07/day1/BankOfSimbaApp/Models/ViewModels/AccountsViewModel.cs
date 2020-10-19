using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimbaApp.Models.ViewModels
{
    public class AccountsViewModel
    {
        public List<BankAccount> Accounts { get; set; }
        public AccountsViewModel(List<BankAccount> accounts)
        {
            Accounts = accounts;
        }
    }
}
