using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            // works, but don't use
            // a = a + b;
            // b = a - b;
            // a = a - b;

            // Use tmeporary variable instead
            int tempNum = a;
            a = b;
            b = tempNum;
        }
    }
}
