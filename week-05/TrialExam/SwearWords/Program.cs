using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SwearWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method which can read and parse a file 
            // containing not so family friendly text. 
            // The method must remove all the given words from the file and 
            //return the amount of the removed words. 
            string filepath = @"d:\C# Exercises\FundationExamExampe\words.txt";
            WordsRemove(filepath);
        }
        public static /*void*/ int WordsRemove(string filepath)
        {
            int removedWords = 0;
            List<string> RemovedWords = new List<string>();

            string[] wtr = { "fuck", "bloody", "cock", "shit", "fucker", "fuckstick", "asshole", "dick", "piss", "cunt" };
            string content = File.ReadAllText(filepath);

            content = content.ToLower();
            content = content.Replace(",", " ,");
            content = content.Replace(".", " .");

            string[] words = content.Split(" ");

            List<string> contentSplit = new List<string>(words);
            for (int i=0; i < contentSplit.Count; i++)
            {
                for (int j = 0; j < wtr.Length; j++)
                {
                    if (contentSplit[i] == wtr[j])
                    {
                        contentSplit.RemoveAt(i);
                        removedWords++;
                    }
                }
            }
            content = String.Join(" ", contentSplit);
            content = content.Replace(" ,", ",");
            content = content.Replace(" .", ".");
            return removedWords;
            Console.WriteLine(content);
        }
    }
}
