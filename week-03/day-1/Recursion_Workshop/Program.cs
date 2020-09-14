using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursion_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GreatestCommonDivisor(192,270));
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

        public static int GreatestCommonDivisor (int num1, int num2)
        {
            int higherNum = Math.Max(num1, num2);
            int lowerNum = Math.Min(num1, num2);
            if (higherNum == 0 || lowerNum == 0)
            {
                return higherNum;
            }
            else
            {
                int remainder = higherNum % lowerNum;
                return GreatestCommonDivisor(lowerNum, remainder);
            }
        }
    }
}
