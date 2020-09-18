using System;
using System.Collections.Generic;
using System.Text;

namespace LetterCounting
{
    public class CountLetters
    {
        // Write a function, that takes a string as an argument
        // and returns a dictionary with all letters in the string as keys,
        // and numbers as values that shows how many occurrences there are.

        public string Text; //  { get; private set; }

        public CountLetters(string text)
        {
            Text = text;
        }
        public Dictionary<char, int> getLettersCounted()
        {
            Dictionary<char, int> countedLetters = new Dictionary<char, int>();

            for (int i=0; i < Text.Length; i++)
            {
                if (countedLetters.ContainsKey(Text[i]))
                {
                    countedLetters[Text[i]]++;
                }
                else
                {
                    countedLetters.Add(Text[i], 1);
                }
            }
            return countedLetters;
        }
    }
}
