using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsefulUtilities.Models.ViewModels
{
    public class ColoredViewModel
    {
        public string Color { get; set; }
        public ColoredViewModel(string color)
        {
            Color = color;
        }
    }
}
