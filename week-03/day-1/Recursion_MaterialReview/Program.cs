using System;

namespace Recursion_MaterialReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialIter(5));
        }
        public static long FactorialIter(int n)
        {
            long result = 1;
            for (int i = 0; i <= n; i++)
            {
                result *= 1;
            }
            return result;
        }

        public static long FactorialRecursive(int n)
        {
            if (n==1)
            {
                return 1;
            }
            else
            {
                return n * FactorialRecursive(n - 1);
            }
        }
        public static int Fibonacci(int n)
        {
            if (n<= 0)
            {
                return 0;
            } 
            else if (n==1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        public static void HanoiTowers(int n, char fromRod, char toRod, char auxRod)
        {
            HanoiTowers(n - 1, fromRod, auxRod, toRod);
            Console.WriteLine($"Moved disk {n} from {fromRod} to {toRod}");
            HanoiTowers(n - 1, auxRod, toRod, fromRod);
        }

    }
}
