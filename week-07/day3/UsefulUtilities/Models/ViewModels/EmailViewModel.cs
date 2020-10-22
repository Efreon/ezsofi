using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsefulUtilities.Models.ViewModels
{
    public class EmailViewModel
    {
        public string Result { get; set; }
        public EmailViewModel(string result)
        {
            Result = result;
        }
    }
}
