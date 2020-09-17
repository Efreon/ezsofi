using System;
using System.Collections.Generic;

namespace DiceSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // You have a `DiceSet` class which has a list for 6 dice
            // You can roll all of them with roll()
            // Check the current rolled numbers with getCurrent()
            // You can reroll with reroll()
            // Your task is to roll the dice until all of the dice are 6
            DiceSet diceSet = new DiceSet();

            /*
            Console.WriteLine(diceSet.GetCurrent());
            diceSet.Roll();
            Console.WriteLine(diceSet.GetCurrent());
            Console.WriteLine(diceSet.GetCurrent(5));
            diceSet.Reroll();
            Console.WriteLine(diceSet.GetCurrent());
            diceSet.Reroll(4);
            Console.WriteLine(diceSet.GetCurrent());
            */

            // SOLUTION 1 //
            diceSet.Roll();
            int diceSum = 0;
            for (int i = 0; i < 6; i++)
            {
                diceSum += diceSet.GetCurrent(i);
            }
            if (diceSum == 36)
            {
                Console.WriteLine("All the dices are 6");
            }
            else
            {
                diceSet.Reroll();
            }

            // SOLUTION 2 // 
            diceSet.Roll();
            for (int i = 0; i < 6; i++)
            {
                while (diceSet.GetCurrent(i) < 6)
                {
                    diceSet.Reroll(i);
                }
            }
        }
    }
}
