using System;

namespace _10_PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // DONE //// Exercise - IWontCheatOnTheExams ////
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I won't cheat on the exam!");
            }

            // DONE  //// Exercise - PrintEven ////
            // Create a program that prints all the even numbers between 0 and 500
            for (int i = 0; i < 501; i++)
            {
                Console.WriteLine(i);
            }

            // DONE //// Exercise - MultiplicationTable ////
            // Create a program that asks for a number and prints the multiplication table with that number
            //
            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150

            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= 10; i++)
            {
                int mult = i * num;
                Console.WriteLine($"{i} * {num} = {mult}");
            }


            // DONE //// Exercise - CountFromTo ////
            // Create a program that asks for two numbers
            Console.WriteLine("Enter a number: ");
            int numFirst = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter one more number: ");
            int numSecond = Convert.ToInt32(Console.ReadLine());

            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            if (numSecond <= numFirst)
            {
                Console.WriteLine("The second number should be bigger");
            }

            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            else
            {
                for (int i = numFirst; i < numSecond; i++)
                {
                    Console.WriteLine(i);
                }
            }

            // DONE //// Exercise - FizzBuzz ////
            // Write a program that prints the numbers from 1 to 100.
            for (int i = 1; i <= 100; i++)
            {
                // For numbers which are multiples of both three and five print “FizzBuzz”.
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // But for multiples of three print “Fizz” instead of the number
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // and for the multiples of five print “Buzz”.
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

                // DONE //// Exercise - DrawTriangle ////
                // Write a program that reads a number from the standard input, then draws a
                // triangle like this:
                //
                // *
                // **
                // ***
                // ****
                //
                // The triangle should have as many lines as the number was
                Console.WriteLine("Enter a number: ");
                int rows = Convert.ToInt32(Console.ReadLine());

                for (int r = 1; r <= rows; r++)
                {
                    for (int c = 1; c <= 2 * r - 1; c++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();

                //// Exercise - Create a row*row size matrix containing the column number, separated by " " ////
                Console.WriteLine("Enter a number: ");
                int rowsM = Convert.ToInt32(Console.ReadLine());

                for (int r = 1; r <= rowsM; r++)
                {
                    for (int c = 1; c <= rowsM; c++)
                    {
                        Console.Write(" " + c);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();


                // DONE //// Exercise - DrawPyramid ////
                // Write a program that reads a number from the standard input, then draws a
                // pyramid like this:
                //
                //
                //    *
                //   ***
                //  *****
                // *******
                //
                // The pyramid should have as many lines as the number was

                Console.WriteLine("Enter a number: ");
                int numPyramid = Convert.ToInt32(Console.ReadLine());
                // int spotsPyramid = numPyramid + (numPyramid - 1);
                int centerPointPyramid = (numPyramid + (numPyramid - 1)) / 2;

                for (int r = 0; r < numPyramid; r++)
                {
                    for (int spotP = 0; spotP < numPyramid * 2; spotP++)
                    // for (int spotP = 0; spotP < spotsPyramid; spotP++)
                    {
                        if (spotP >= centerPointPyramid - r && spotP <= centerPointPyramid + r)
                        // if (spotP >= spotsPyramid / 2 - r && spotP <= spotsPyramid / 2 + r)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
                */

                // NOT DONE//// Exercise - DrawDiamond ////
                // Write a program that reads a number from the standard input, then draws a
                // diamond like this:
                //    *
                //   ***
                //  *****
                // *******
                //  *****
                //   ***
                //    *
                // The diamond should have as many lines as the number was
                Console.WriteLine("Enter a number: ");
                int rowDiamond = Convert.ToInt32(Console.ReadLine());

                for(int r=0; )

                



                /*
                // DONE //// DrawSquare ////
                // Write a program that reads a number from the standard input, then draws a
                // square like this:
                //
                //
                // %%%%%%
                // %    %
                // %    %
                // %    %
                // %    %
                // %%%%%%
                //
                // The square should have as many lines as the number was

                Console.WriteLine("Enter a number: ");
                int numSquare = Convert.ToInt32(Console.ReadLine());

                for (int r = 1; r <= numSquare; r++)
                {
                    if (r == 1 || r == numSquare)
                    {
                        for (int c = 1; c <= numSquare; c++)
                        {
                            Console.Write("%");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int c = 1; c <= numSquare; c++)
                            if (c == 1 || c == numSquare)
                            {
                                Console.Write("%");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }

                }
                Console.ReadLine();


                //// DrawDiagonal ////
                // Write a program that reads a number from the standard input, then draws a
                // square like this:
                //
                //
                // %%%%%
                // %%  %
                // % % %
                // %  %%
                // %%%%%
                //
                // The square should have as many lines as the number was

                //// GuessTheNumber ////
                // Write a program that stores a number, and the user has to figure it out.
                // The user can input guesses, after each guess the program would tell one
                // of the following:
                //
                // The stored number is higher
                // The stried number is lower
                // You found the number: 8

                //// ParametricAverage ////
                // Write a program that asks for a number.
                // It would ask this many times to enter an integer,
                // if all the integers are entered, it should print the sum and average of these
                // integers like:
                //
                // Sum: 22, Average: 4.4

                //// DrawChessTable ////
                // Crate a program that draws a chess table like this
                //
                // % % % %
                //  % % % %
                // % % % %
                //  % % % %
                // % % % %
                //  % % % %
                // % % % %
                //  % % % %
                //

                //// SubStr ////
                //  Create a function that takes two strings as a parameter
                //  Returns the starting index where the second one is starting in the first one
                //  Returns `-1` if the second string is not in the first one

                //  Example:

                //  should print: `17`
                Console.WriteLine(Substr("this is what I'm searching in", "searching"));

                //  should print: `-1`
                Console.WriteLine(Substr("this is what I'm searching in", "not"));
            }

            static int Substr(string input, string q)
            {
                return -1;
            }
                */
        }
    }
}
