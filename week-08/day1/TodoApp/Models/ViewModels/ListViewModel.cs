using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models.ViewModels
{
    public class ListViewModel
    {
        public string Text { get; set; }
        public ListViewModel()
        {
            Text = "This is my first todo";
        }
    }
}
