using System;
using System.Security.Cryptography.X509Certificates;

namespace Week1_Day2_Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1 - Third");
            int[] numbers = { 4, 5, 6, 7 };
            Third(numbers);
            Console.WriteLine();

            Console.WriteLine("Exercise 2 - Compare Length");
            int[] firstArrayOfNumbers = { 1, 2, 3 };
            int[] secondArrayOfNumbers = { 4, 5 };
            CompareLength(firstArrayOfNumbers, secondArrayOfNumbers);
            Console.WriteLine();

            Console.WriteLine("Exercise 3 - SumElements");
            int[] numbers3 = { 54, 23, 66, 12 };
            SumElements(numbers3);
            Console.WriteLine();

            Console.WriteLine("Exercise 4 - ChangeElements");
            int[] numbers4 = { 1, 2, 3, 8, 5, 6 };
            ChangeElements(numbers4);
            Console.WriteLine();

            Console.WriteLine("Exercise 5 - IncrementElement");
            int[] numbers5 = { 1, 2, 3, 4, 5 };
            IncrementElement(numbers5);
            Console.WriteLine();

            Console.WriteLine("Exercise 6 - PrintElements");
            int[] numbers6 = { 4, 5, 6, 7 };
            PrintElements(numbers6);
            Console.WriteLine();

            Console.WriteLine("Exercise 7 - DiagonalMatrix");
            var matrix = new int[4,4];
            DiagonalMatrix(matrix);
            Console.WriteLine();

            Console.WriteLine("Exercise 8 - DoubleItem");
            int[] numList = { 3, 4, 5, 6, 7 };
            DoubleItems(numList);
            Console.WriteLine();

            Console.WriteLine("Exercise 9 - Colors");
            Colors();
            Console.WriteLine();

            Console.WriteLine("Exercise 10 - AppendA");
            var animals = new string[] { "koal", "pand", "zebr" };
            AppendA(animals);
            Console.WriteLine();

            Console.WriteLine("Exercise 11 - SwapElements");
            var orders = new string[] { "first", "second", "third" };
            SwapElements(orders);
            Console.WriteLine();

            Console.WriteLine("Exercise 12 - SumAll");
            var numbers12 = new int[] { 3, 4, 5, 6, 7 };
            SumAll(numbers12);
            Console.WriteLine();

            Console.WriteLine("Exercise 13 - Reverse");
            var numbers13 = new int[] { 3, 4, 5, 6, 7 };
            Reverse(numbers13);
            Console.WriteLine();
        }

        //// Exercise 1 - Third ////
        public static void Third(int[] numbers)
        {
            // -Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print the third element of `numbers`
            Console.WriteLine(numbers[2]);
        }

        //// Exercise 2 - Compare Length ////
        public static void CompareLength(int[] firstArrayOfNumbers, int[] secondArrayOfNumbers)
        {
            // - Create an array variable named `firstArrayOfNumbers`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `secondArrayOfNumbers`
            //   with the following content: `[4, 5]`
            // - Print "secondArrayOfNumbers is longer" if 
            //   `secondArrayOfNumbers` has more elements than
            //   `firstArrayOfNumbers`
            if (firstArrayOfNumbers.Length < secondArrayOfNumbers.Length)
            {
                Console.WriteLine("secondArrayOfNumbers has more elements than firstArrayOfNumbers");
            }
            else if (firstArrayOfNumbers.Length < secondArrayOfNumbers.Length)
            {
                Console.WriteLine("firstArrayOfNumbers has more elements than secondArrayOfNumbers");
            }
            else
            {
                Console.WriteLine("The two arrays have the same elements");
            }
        }

        //// Exercise 3 - SumElements ////
        public static void SumElements(int[] numbers3)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element
            Console.WriteLine(numbers3[1] + numbers3[2]);
        }

        //// Exercise 4 - ChangeElements ////
        public static void ChangeElements(int[] numbers4)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4

            for (int i = 0; i < numbers4.Length; i++)
            {
                if (numbers4[i] == 8)
                {
                    numbers4[i] = 4;
                }
            }
            // - Print the fourth element
            Console.WriteLine(numbers4[3]);
        }

        //// Exercise 5 - IncrementElement ////
        public static void IncrementElement(int[] numbers5)
        {
            //- Create an array variable named `numbers`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            for (int i=0; i<numbers5.Length; i++)
            {
                if (i== 2)
                {
                    numbers5[i] = numbers5[i]+1;
                }
            }
            //- Print the third element
            Console.WriteLine(numbers5[2]);
        } 
        
        //// Exercise 6 - PrintElements ////
        public static void PrintElements(int[] numbers6)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `numbers`
            for (int i= 0; i < numbers6.Length; i++)
            {
                Console.Write(numbers6[i] + " ");
            }
            Console.WriteLine();
        }

        //// Exercise 7 - DiagonalMatrix ////
        public static void DiagonalMatrix(int [,] matrix)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            // - Print this two dimensional array to the output
            for (int rm=0; rm<matrix.GetLength(0); rm++)
            {
                for (int cm=0; cm <matrix.GetLength(0); cm++)
                {
                    if (rm == cm)
                    {
                        matrix[rm, cm] = 1;
                    }
                    Console.Write(matrix[rm, cm]);
                }
                Console.WriteLine();
            }
            
        }

        //// Exercise 8 - DoubleItems ////
        public static void DoubleItems(int[] numList)
        {
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
            for (int di = 0; di < numList.Length; di++)
            {
                numList[di] *= 2;
                Console.Write(numList[di] + " ");
            }
            Console.WriteLine();
        }

        //// Exercise 9 - Colors ////
        public static void Colors()
        {
            // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`

            string[][] colors = new string[3][];
            colors[0] = new[] { "lime", "forest green", "olive", "pale green", "spring green" };
            colors[1] = new[] { "orange red", "red", "tomato" };
            colors[2] = new[] { "orchid", "violet", "pink", "hot pink" };

            foreach(string[] row in colors)
            {
                foreach (string col in row)
                    Console.Write(col + " ");
                Console.WriteLine();
            }
        }

        //// Exercise 10 - AppendA ////
        public static void AppendA(string[] animals)
        {
            // - Create an array variable named `animals`
            //   with the following content: `["koal", "pand", "zebr"]`
            // - Add all elements an `"a"` at the end
            for (int anim = 0; anim < animals.Length; anim++)
            {
                animals[anim] = animals[anim] + "a";
            }
            foreach(string an in animals)
            {
                Console.Write(an + " ");
            }
            Console.WriteLine();
        }

        //// Exercise 11 - SwapElements ////
        public static void SwapElements(string[] orders)
        {
            // - Create an array variable named `orders`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `orders`
            string ordersFirst = orders[0];

            orders[0] = orders[2];
            orders[2] = ordersFirst;

            foreach(string ord in orders)
            {
                Console.Write(ord + " ");
            }
            Console.WriteLine();
        }

        //// Exercise 12 - SumAll ////
        public static void SumAll(int[] numbers12)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `numbers`
            int sumAll = 0;
            for (int i=0; i < numbers12.Length; i++)
            {
                sumAll += numbers12[i];
            }
            Console.WriteLine(sumAll);
        }

        //// Exercise 13 - Reverse ////
        public static void Reverse(int[] numbers13)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `numbers`
            // - Print the elements of the reversed `numbers`
            Array.Reverse(numbers13);
            foreach (int num in numbers13)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

    }
}
