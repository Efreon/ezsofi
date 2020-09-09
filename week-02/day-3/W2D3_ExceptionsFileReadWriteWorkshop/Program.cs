using System;
using System.Linq.Expressions;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace W2D3_ExceptionsFileReadWriteWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int number = 0;
            DivideByZero(number);

            string filePath = @"d:\greenfox\ezsofi\week-02\day-3\my-file.txt";
            PrintEachLine(filePath);

            string fileName = @"my-file.txt";
            CountLines(fileName);

            string filePath2 = @"d:\greenfox\ezsofi\week-02\day-3\my-file.txt";
            WriteSingleLine(filePath2);

            string filePath3 = @"d:\greenfox\ezsofi\week-02\day-3\my-file2.txt";
            string word = "word";
            int numb = 2;
            WriteMultipleLines(filePath3, word, numb);

            string originFile = @"d:\greenfox\ezsofi\week-02\day-3\my-file2.txt";
            string copyFile = @"d:\greenfox\ezsofi\week-02\day-3\my-file3.txt";
            CopyFile(originFile, copyFile);
            
            string filePathDoubled = @"d:\greenfox\ezsofi\week-02\day-3\duplicated-chars.txt";
            string filePathDoubledCorrected = @"d:\greenfox\ezsofi\week-02\day-3\duplicated-chars-corrected.txt";
            Doubled(filePathDoubled, filePathDoubledCorrected);

            string inputFile = @"d:\greenfox\ezsofi\week-02\day-3\reversed-lines.txt";
            string outputFile = @"d:\greenfox\ezsofi\week-02\day-3\reversed-lines-corrected.txt";
            ReversedLines(inputFile, outputFile);
            
            string inputFile2 = @"d:\greenfox\ezsofi\week-02\day-3\reversed-order.txt";
            string outputFile2 = @"d:\greenfox\ezsofi\week-02\day-3\reversed-order-corrected.txt";
            ReversedOrder(inputFile2, outputFile2);
            */
            string inputFile3 = @"d:\greenfox\ezsofi\week-02\day-3\log.txt";
            // string outputFile3 = @"d:\greenfox\ezsofi\week-02\day-3\reversed-order-corrected.txt";
            Logs(inputFile3);
            
        }

        //// Exercise 1 ////
        static void DivideByZero(int number)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0
            try
            {
                int divideTen = 10 / number;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("fail");
            }
        }

        //// Exercise 2 ////
        static void PrintEachLine(string filePath)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"
            try
            {
                string[] content = File.ReadAllLines(filePath);
                Console.WriteLine(content);
            }
            catch (Exception)
            {
                Console.WriteLine($"Unable to read file:{filePath}");
            }
        }

        //// Exercise 3 ////
        static void CountLines(string fileName)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            try
            {
                // string[] lines = File.ReadAllLines(fileName);
                var lineCount = 0;
                using (var sw = new StreamReader(fileName))
                {
                    while (sw.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }
                Console.WriteLine(lineCount);
            }
            catch (Exception)
            {
                Console.WriteLine("0");
            }
        }

        //// Exercise 4 ////
        static void WriteSingleLine(string filePath2)
        {
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"
            try 
            {
                File.WriteAllText(filePath2, "Zsófi Kovács");
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
        }

        //// Exercise 5 ////
        static void WriteMultipleLines(string filePath3, string word, int numb)
        {
            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.

            using (StreamWriter sw = new StreamWriter(filePath3))
            {
                for (int i= 0; i <numb; i++)
                {
                    sw.WriteLine(word);
                }
            }
        }
        
        //// Exercise 6 ////
        static void CopyFile(string originFile, string copyFile)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            var readLines = "";
            try
            {
                using (var sr = new StreamReader(originFile))
                {
                    readLines = sr.ReadToEnd();
                }
                using (var sw = new StreamWriter(copyFile))
                {
                    sw.WriteLine(readLines);
                }
                Console.WriteLine(true);
            }
            catch (Exception)
            {
                Console.WriteLine(false);
            }
        }
       
        //// Exercise 7 ////
        static void ReversedLines(string inputFile, string outputFile)
        {
            List<string> listLines = new List<string>();
            var outputText = new StringBuilder();
            using (var sr = new StreamReader(inputFile))
            {
                string line;
                while ((line = sr.ReadLine()) !=null)
                {
                    listLines.Add(line);
                }
            }
            for (int i = 0; i < listLines.Count; i++)
            {
                char[] characters = listLines[i].ToCharArray();
                string reverse = "";
                for (int j= characters.Length - 1; j >= 0; j--)
                {
                    reverse += characters[j];
                }
                outputText.Append(reverse + "\r\n");

            }
            using (var sw = new StreamWriter(outputFile))
            {
                sw.WriteLine(outputText);
            }
        }
        
        //// Exercise 8 ////
        static void Doubled(string filePathDoubled, string filePathDoubledCorrected) 
        {
            var readLines = new StringBuilder();
            using (var sr = new StreamReader(filePathDoubled))
            {
                readLines = new StringBuilder(sr.ReadToEnd());
            }
            for (int i = 0; i < readLines.Length - 1; i++)
                if (readLines[i] == readLines[i + 1]) 
                {
                    readLines.Remove(i + 1, 1);
                    i--;
                }
            using (var sw = new StreamWriter(filePathDoubledCorrected))
            {
                sw.WriteLine(readLines);
            }
        }

        //// Exercise 9 ////
        static void ReversedOrder(string inputFile2, string outputFile2)
        {
            List<string> listLines = new List<string>();
            var outputText = new StringBuilder();
            using (var sr = new StreamReader(inputFile2))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listLines.Add(line);
                }
            }
            for (int i = listLines.Count - 1; i>= 0; i--)
            {
                outputText.Append(listLines[i] + "\r\n");
            }
            using (var sw = new StreamWriter(outputFile2))
            {
                sw.WriteLine(outputText);
            }
        }

        //// Exercise 10 ////
        static void Logs(string inputFile3)
        {
            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.
            List<string> listLines = new List<string>();
            var outputText = new StringBuilder();
            using (var sr = new StreamReader(inputFile3))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listLines.Add(line);
                }
                for (int i=0; i < listLines.Count; i++)
                {
                    Console.WriteLine(listLines[i]);
                }
            }
        }
        

    }
}

