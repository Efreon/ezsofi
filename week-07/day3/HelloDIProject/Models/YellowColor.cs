using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDIProject.Models
{
    public class YellowColor :IColor
    {
        public YellowColor()
        {
        }
        public void PrintColor()
        {
            Console.WriteLine("It is yellow in color...");
        }
    }
}
