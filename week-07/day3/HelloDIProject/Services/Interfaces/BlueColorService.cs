using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDIProject.Models
{
    public class BlueColorService : IColor
    {
        public PrinterService PrinterService;
        public BlueColorService(PrinterService printer)
        {
            PrinterService = printer;
        }
        public void PrintColor()
        {
            PrinterService.Log("It is blue in color");
        }
    }
}
