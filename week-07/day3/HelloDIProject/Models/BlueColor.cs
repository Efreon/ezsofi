using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDIProject.Models
{
    public class BlueColor : IColor
    {
        public Printer MyPrinter;
        public BlueColor(Printer printer)
        {
            MyPrinter = printer;
        }
        public void PrintColor()
        {
            MyPrinter.Log("sdfsdfdsfs");
        }
    }
}
