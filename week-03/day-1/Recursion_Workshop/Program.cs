using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursion_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Power(5,3));
        }

        public static long NumberAdder(int n)
        {
            if (n==1)
            {
                return 1;
            }
            else
            {
                return n + NumberAdder(n - 1);
            }
        }
        public static int SumDigits(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return (n % 10 + SumDigits(n / 10));
            }
        }

        public static long Power(int baseNum, int powerNum)
        {
            if(baseNum == 1)
            {
                return 1;
            }
            else if (powerNum == 1)
            {
                return baseNum;
            }
            else
            {
                return baseNum * Power(baseNum, powerNum-1);
            }
        }
    }
}
