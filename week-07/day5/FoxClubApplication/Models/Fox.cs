using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClubApplication.Models
{
    public class Fox
    {
        public string FoxName { get; set; }
        public Fox(string foxName)
        {
            FoxName = foxName;
        }
    }
}
