using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTApiWs.Models;

namespace RESTApiWs.Services
{
    public class APIService : IAPIService
    {
        public APIService()
        {

        }

        public int? Sum(int? num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num + Sum(num - 1);
            }

        }

        #region ArrayCalculations
        public int? Factorial(int? number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }

        public int? SumArray(int[] numbers)
        {
            int? result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }
        public int? MultiplyArray(int[] numbers)
        {
            int? result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                result *= numbers[i];
            }
            return result;
        }
        public int[] DoubleArray(int[] numbers)
        {
            int[] resultArray = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                resultArray[i] = numbers[i] * 2;
            }
            return resultArray;
        }
        #endregion

        #region StarWars
        public string YodaSpeak(string text)
        {
            StringBuilder sith_text = new StringBuilder();
            string[] randomParts = new string[] { "argh", "uhmm", "err", "hmm" };

            string[] sentences = text.Split(". ");

            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Split(" ");

                string newSentence = "";
                for (int j = 1; j < words.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        string switchedWords = words[j] + " " + words[j - 1];
                        newSentence += " " + switchedWords;
                    }
                    else if (j == words.Length - 1)
                    {
                        newSentence += " " + words[j] + ".";
                    }
                }
                newSentence = newSentence.ToLower();
                sith_text.Append(newSentence.Substring(0,1).ToUpper() + newSentence.Substring(1, newSentence.Length-1));
                sith_text.Insert(sith_text.Length-1, randomParts[new Random().Next(1, 5)].ToString() + ".", new Random().Next(1, 3));
            }
            return sith_text.ToString();
        }
        #endregion
    }
}
