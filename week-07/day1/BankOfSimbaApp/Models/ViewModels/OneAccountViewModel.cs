using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimbaApp.Models.ViewModels
{
    public class OneAccountViewModel
    {
        public BankAccount Account { get; set; }
        public OneAccountViewModel(BankAccount account)
        {
            Account = account;
        }
    }
}
