using System;
using System.Diagnostics.CodeAnalysis;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            /*int i, n, sum = 0;
            double avg;

            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4*/

            // int i, n, sum = 0;
            int i = 0;
            int n = 0;
            int sum = 0;
            double avg;

            Console.Write("Enter 5 numbers : \n");
            for (i = 1; i <= 5; i++)
            {
                Console.Write($"Number {i}:");

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 5;
            Console.WriteLine($"The sum is {sum} and the Average is {avg}");
        }
    }
}
