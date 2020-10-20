using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            Console.Write("Enter a number: ");
            int number;

            number = Convert.ToInt32(Console.ReadLine());

            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            // odd - páratlan; even - páros
            if (number % 2 == 0)
            {
                Console.Write("Even");
            }
            else
            {
                Console.Write("Odd");
            }
        }
    }
}
