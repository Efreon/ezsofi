using System;
using System.Collections.Generic;
using System.Linq;

namespace Recursion_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bunnies2(10));
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

        public static int Bunnies(int bunnies)
        {
            // We have a number of bunnies and each bunny has two big floppy ears. 
            // We want to compute the total number of ears across all the bunnies recursively 
            //(without loops or multiplication).
            if (bunnies == 0)
            {
                return 0;
            }
            else
            {
                return 2 + Bunnies(bunnies - 1);
            }
        }
        public static int Bunnies2(int bunnies)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... 
            // The odd bunnies (1, 3, ..) have the normal 2 ears. 
            // The even bunnies (2, 4, ..) we'll say have 3 ears, because they each have a raised foot. 
            // Recursively return the number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
            if (bunnies == 0)
            {
                return 0;
            } 
            else
            {
                if (bunnies % 2 == 0)
                {
                    return 3 + Bunnies2(bunnies - 1);
                }
                else
                {
                    return 2 + Bunnies2(bunnies - 1);
                }
            }
        }
    }
}
