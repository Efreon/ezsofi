using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClubApplication.Models.ViewModels
{ 
    public class FoxViewModel
    {
        public Fox CurrentFox { get; set; }
        public FoxViewModel(Fox currentFox)
        {
            CurrentFox = currentFox;
        }

    }
}


