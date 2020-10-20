using System;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int number_max = Int32.MaxValue; // highest possible number
            double numberTwo = 5.5d;
            decimal currency = 5.12458M;
            float anotherNumber = 5.2f;

            string text = "Zsófi";      // that's an object, not as numbers or booleans; "" for string
            char character = 'z';       // '' for characters

            bool isCorrect = true;      // naming convention is_

            int number_arit = (5 + 5) * 98;
            int number_mod= 6 % 3;         // modulo; terurns the remainder; use to odd-even calculations

            bool isEven = 5 % 2 >= 0 || 1 !=1;   // returns the boolean value; == comparison

            isEven = !isEven;

            string sentence = "Hello, my name is Zsófi";
            string addition = sentence + "blablanlasnd";

            string name = "Zsófi";
            string addition2 = $"Hello, my name is {name}";
            Console.WriteLine(addition2);

            char letter = name[0];
            Console.WriteLine(letter);

            int length = name.Length;
            char lastChar = name.Length - 1;
        }
    }
}
