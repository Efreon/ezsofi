using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class GreetingNational
    {
        public string RandomHello { get; set; }
        public string RandomColor { get; set; }
        public string RandomFontSize { get; set; }
        public GreetingNational(string hello, string color, string size)
        {
            RandomHello = hello;
            RandomColor = color;
            RandomFontSize = size;
        }
    }
}
