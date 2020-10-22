using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDIProject.Models
{
    public class YellowColorService :IColor
    {
        public YellowColorService()
        {
        }
        public void PrintColor()
        {
            Console.WriteLine("It is yellow in color...");
        }
    }
}
