using System;

namespace MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            Console.WriteLine("Please write a distance in miles with number!");
            double mile;
            if (!double.TryParse(Console.ReadLine(), out mile))
            {
                Console.WriteLine("Please write a distance in miles with number!");
            }

            // then it converts that value to kilometers and prints it
            double converter = 1.609344;
            double kilometre = mile * converter;

            if (mile <=1 && kilometre <=1)
            {
                Console.WriteLine($"{mile} mile is {kilometre} kilometre");
            }
            else if (mile <= 1 && kilometre > 1)
            {
                Console.WriteLine($"{mile} mile is {kilometre} kilometres");
            }
            else
            {
                Console.WriteLine($"{mile} miles are {kilometre} kilometres");
            }
            
        }
    }
}
