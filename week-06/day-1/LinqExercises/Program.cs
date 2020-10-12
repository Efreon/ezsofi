using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace LinqExercises
{
    class Program
    {
        delegate double del(int x);
        static void Main(string[] args)
        {
            // Exercise 1 //
            // Write a LINQ Expression to get the even numbers from the following array:
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var evens = n.Where(x => x % 2 == 0).ToList();

            // Exercise 2 //
            // Write a LINQ Expression to get the average value of the odd numbers from the following array:
            var avg = n.Where(x => x % 2 != 0).Average();


            // Exercise 3 //
            // Write a LINQ Expression to get the squared value of the positive numbers from the following array:
            var sqrd = n.Where(x => x > 0).Select(x => x * x).ToList();

            // Exercise 4 //
            // Write a LINQ Expression to find which number squared value is more then 20 from the following array:
            int[] n4 = new[] { 3, 9, 2, 8, 6, 5 };
            var sqrdHigher20 = n4.Where(x => x * x > 20).ToList();

            // Exercise 5 //
            // Write a LINQ Expression to find the frequency of numbers in the following array:
            int[] n5 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var frequency = n5.GroupBy(x => x)
                              .Select(g => new { number = g.Key, frequency = g.Count() })
                              .OrderBy(g => g.frequency);
            // Exercise 6 //
            // Write a LINQ Expression to find the frequency of characters in a given string.
            string s = "asfsdfdsfdsfSDAFGDSF";
            var letterFrequency = s.GroupBy(x => x)
                                   .Select(x => new { letter = x.Key, frequency = x.Count() })
                                   .OrderBy(x => x.frequency);

            // Exercise 7 //
            // Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var citiesAI = cities.Where(x => x[0] == 'A' && x[x.Length - 1] == 'I');

            // Exercise 8 //
            // Write a LINQ Expression to find the uppercase characters in a string.
            string s8 = "dsfdsfsdndajCASSDAJDNASFSNFNDSnefsnjnj";
            var upperChars = s8.Where(x => char.IsUpper(x));

            // Exercise 9 //
            //Write a LINQ Expression to convert a char array to a string.
            char[] arr = { 'a', 'b', 'c', 'd' };
            var arrayToString = String.Join("", arr.Select(x => x));

            // Exercise 10 //
            // Fill a list with at least 5 foxes, it's up to you how you name/create them.
            List<Fox> foxes = new List<Fox>();
            foxes.Add(new Fox("foxy1", "pallida", "green"));
            foxes.Add(new Fox("foxy2", "abc", "orange"));
            foxes.Add(new Fox("foxy3", "adsadsada", "green"));
            foxes.Add(new Fox("foxy4", "pallida", "brown"));
            foxes.Add(new Fox("foxy5", "dfdwfds", "red"));

            // Write a LINQ Expression to find the foxes with green color.
            var greenFoxes = foxes.Where(x => x.Color == "green");
            // Write a LINQ Expression to find the foxes with green color and pallida type.
            var greenPallidaFoxes = foxes.Where(x => x.Color == "green" && x.Type == "pallida");

            // Exercise 11 //
            // Create a single LINQ expression which reads all text from this file, 
            //and prints the 100 most common words in descending order. 
            // Keep in mind that the text contains punctuation characters which should be ignored. 

            string filePath = @"D:\greenfox\ezsofi\week-06\day-1\wikipedia.txt";
            string content = File.ReadAllText(filePath);
            char[] punctuation = new char[] { '.', ',', '!', '?', ';', ':', '-', '(', ')', '/', '\n', '[', ']', ' ' };
            var top100Word = content.ToLower()
                                    .Split(punctuation)
                                    .GroupBy(x => x)
                                    .ToDictionary(x => x.Key, x => x.Count())
                                    .Where(x => x.Key != "")
                                    .OrderByDescending(x => x.Value)
                                    .Take(100);
            //foreach (var word in top100Word)
            //{
            //    Console.WriteLine($"{word.Key}: {word.Value}");
            //}

            
            // Exercise 12 //

            string filePathSW = @"D:\greenfox\ezsofi\week-06\day-1\swcharacters.csv";
            var linesSW = File.ReadAllLines(filePathSW)
                              .Skip(1) // do not read the first line, as it's the header
                              .Select(x => x.Split(';'))
                              ;

            var heaviestCharacter = linesSW
                                    .Where(x => x[2] != "unknown")
                                    // .Cast<int>()
                                    .OrderByDescending(x => x[2])
                                    // .Take(1)
                                    .Select(x => x)
                                    .ToList()
                                    ;

            foreach (var item in heaviestCharacter)
            {
                Console.WriteLine($"{item[0]} - {item[2]}");
            }
            ////create a new StreamReader
            //StreamReader sr = new StreamReader(filePathSW);
            ////read the first line of the csv and split by the delimiter; those will be the header of the table
            //string[] headers = sr.ReadLine().Split(';');
            ////create a new DataTable
            //DataTable dt = new DataTable();

            //foreach (string header in headers)
            //{
            //    dt.Columns.Add(header);
            //}
            //while (!sr.EndOfStream)
            //{
            //    string[] rows = sr.ReadLine().Split(";");
            //    DataRow dr = dt.NewRow();
            //    for (int i = 0; i < headers.Length; i++)
            //    {
            //        dr[i] = rows[i];
            //    }
            //    dt.Rows.Add(dr);
            //}
            //// Create single LINQ expressions to perform the following exercises:
            //// Print the name of the heaviest character(if the mass is unknown, ignore that character)

            //var results = from myRow in dt.AsEnumerable()
            //              where myRow.Field<string>("mass") != "unknown"
            //              select myRow;

        }
    }
}
