using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDIProject.Models
{
    public class RedColor :IColor
    {
        public RedColor()
        { 
        }
        public void PrintColor()
        {
            Console.WriteLine("It is red in color...");
        }
    }
}
