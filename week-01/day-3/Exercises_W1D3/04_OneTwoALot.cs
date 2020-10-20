using System;

namespace OneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number form the standard input,
            Console.Write("Enter a number: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            // If the number is zero or smaller it should print: Not enough
            if (num<=0)
            {
                Console.Write("Not enough");
            }
            // If the number is one it should print: One
            else if (num == 1)
            {
                Console.Write("One");
            }
            // If the number is two it should print: Two
            else if (num == 2)
            {
                Console.Write("Two");
            }
            // If the number is more than two it should print: A lot
            else
            {
                Console.Write("A lot");
            }


        }
    }
}
