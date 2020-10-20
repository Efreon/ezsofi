using System;

namespace _05_PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            Console.Write("Enter a number: ");
            
            int firstNumber;
            firstNumber = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter another number: ");
            int secondNumber;
            secondNumber = Convert.ToInt32(Console.ReadLine());

            //and prints the bigger one
            if (firstNumber<=secondNumber)
            {
                Console.Write(secondNumber);
            }
            else
            {
                Console.Write(firstNumber);
            }
                
                
        }
    }
}
