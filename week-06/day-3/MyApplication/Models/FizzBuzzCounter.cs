using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApplication.Models
{
    public class FizzBuzzCounter
    {
        public long Id { get; set; }
        public static int callCounter;
        public string Word { get; set; }
        public string FontSize;

        //public FizzBuzzCounter()
        //{
        //}
        public FizzBuzzCounter()
        {
            callCounter++;
            Id = callCounter;
            Word = GetWord();
            FontSize = GetSize();
        }

        public string GetWord()
        {
            var word = string.Empty;
            if (Id % 3 == 0 && Id % 5 == 0 && Id % 7 == 0)
            {
                word = "FizzBuzzWoof";
            }
            else if (Id % 3 == 0 && Id % 5 == 0)
            {
                word = "FizzBuzz";
            }
            else if (Id % 3 == 0 && Id % 7 == 0 || Id % 5 == 0 && Id % 7 == 0)
            {
                word = "FizzWoof";
            }
            else if (Id % 5 == 0 && Id % 7 == 0)
            {
                word = "BuzzWoof";
            }
            else if (Id % 3 == 0)
            {
                word += "Fizz";
            }
            else if (Id % 5 == 0)
            {
                word += "Buzz";
            }
            else if (Id % 7 == 0)
            {
                word += "Woof";
            }
            else word = Id.ToString();
            return word;
        }
        public string GetSize()
        {
            var fontSize = string.Empty;
            if (Id % 3 == 0 && Id % 5 == 0 && Id % 7 == 0)
            {
                fontSize = "72px";
            }
            else if (Id % 3 == 0 && Id % 5 == 0 || Id % 3 == 0 && Id % 7 == 0 || Id % 5 == 0 && Id % 7 == 0)
            {
                fontSize = "48px";
            }
            else if (Id % 3 == 0 || Id % 5 == 0 || Id % 7 == 0)
            {
                fontSize = "24px";
            }
            else
            {
                fontSize = "12px";
            }
            return fontSize;
        }
    }
}
