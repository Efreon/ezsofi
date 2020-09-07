using System;
using System.Globalization;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1 - Doubling");
            int baseNum = 123;
            Doubling(baseNum);

            Console.WriteLine("Exercise 2 - Greed");
            string al = "Green Fox";
            Greet(al);

            Console.WriteLine("Exercise 3- AppendAFunc");
            string typo = "Chinchill";
            AppendAFunc(typo);

            Console.WriteLine("Exercise 4 - Sum");
            int topNum = 50;
            Console.WriteLine(Sum(topNum));

            Console.WriteLine("Exercise 5 - Factorial");
            int inputNum = 5;
            Factorio(inputNum);

            Console.WriteLine("Exercise 6 - SubInt");
            int numCheck = 5;
            var arrayCheck = new int[] { 1, 11, 34, 52, 61 };
            SubInt(numCheck, arrayCheck);

        }

        // Exercise 1 - Doubling //
        public static void Doubling(int baseNum)
        {
            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`
            Console.WriteLine(baseNum * 2);
        }

        // Exercise 2 - Greet //
        public static void Greet(string al)
        {
            // -Create a string variable named `al` and assign the value `Green Fox` to it
            // - Create a function called `Greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Green Fox`
            // - Greet `al`
            Console.WriteLine($"Greetings dear, {al}!");
        }

        // Exercise 3 - AppendAFunc //
        public static void AppendAFunc(string typo)
        {
            // - Create a string variable named `typo` and assign the value `Chinchill` to it
            // - Write a function called `AppendAFunc` that gets a string as an input,
            //   appends an 'a' character to its end and returns with a string
            // - Print the result of `AppendAFunc(typo)`
            Console.WriteLine(typo + 'a');
        }

        // Exercise 4 - Sum //
        public static int Sum(int topNum)
        {
            // Write a function called `sum` 
            // that returns the sum of numbers from zero to the given parameter
            int sumNum = 0;
            for (int i=0; i <= topNum; i++)
            {
                sumNum += i;
            }
            return sumNum;
        }

        // Exercise 5 - Factorial //
        public static void Factorio(int inputNum)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial
            int factorial = 1;
            if (inputNum > 1)
            {
                for (int i = 2; i <= inputNum; i++)
                {
                    factorial *= i;
                }
            }
            else
            {
                factorial = 1;
            }
            Console.WriteLine(factorial);
        }

        // Exercise 6 - SubInt //
        public static void SubInt(int numCheck, int[] arrayCheck)
        {
            //  Create a function that takes a number and an array of integers as a parameter
            //  Returns the indices of the integers in the array of which the first number is a part of
            //  Or returns an empty array if the number is not part of any of the integers in the array
            //  Example:
            // Console.WriteLine(SubInt(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            // Console.WriteLine(SubInt(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'

            string[] stringArray = Array.ConvertAll(arrayCheck, ele => ele.ToString());
            string arrayFirst = stringArray[];

            for (int i=0; i <= arrayFirst.Length; i++)
            {
                Console.WriteLine(arrayFirst[0]);
            }
            
            /*var indexNum = new int[] { };
            for (int i=0; i <= stringArray.Length; i++ )
            {
                for (int j=0; j < stringArray[i].Length; j++)
                {

                }
            }*/

            string testStr = "abc123";
            for (int counter = 0; counter < testStr.Length; counter++)
            {
                Console.WriteLine(testStr[counter].ToString());
            }

        }
    }
}
