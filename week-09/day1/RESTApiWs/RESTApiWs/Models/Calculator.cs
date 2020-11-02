using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiWs.Models
{
    public class Calculator
    {
        public string Error { get; set; }
        public double Received { get; set; }
        public double Result { get; set; }

        public Calculator(double input)
        {
            
        }
        
        public Calculator()
        {

        }
    }
}
