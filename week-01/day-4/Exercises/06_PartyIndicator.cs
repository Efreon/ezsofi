using System;

namespace _06_PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            Console.Write("Number of girls: ");
            int numGirls = Convert.ToInt32(Console.ReadLine());

            // second the boys
            Console.Write("Number of boys: ");
            int numBoys = Convert.ToInt32(Console.ReadLine());

            int totalParticipants = numGirls + numBoys;

            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            if (numGirls == 0)
            {
                Console.Write("Sausage party");
            }

            // It should print: Average party...
            // If there are less people coming than 20
            else if (totalParticipants < 20)
            {
                Console.WriteLine("Average party...");
            }

            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            else if (totalParticipants > 20 && numGirls != numBoys)
            {
                Console.WriteLine("Quite cool party!");
            }

            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            else if (totalParticipants > 20 && numGirls == numBoys)
            {
                Console.WriteLine("The party is excellent!");
            }
        }
    }
}
