using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramChecker
{
    public class Anagram
    {
        string Input1 = "";
        string Input2 = "";

        public Anagram(string input1, string input2)
        {
            Input1 = input1;
            Input2 = input2;
        }
        public bool getAnagram()
        {
            if (Input1.Length != Input2.Length)
            {
                return false;
            }
            else
            {
                var text1 = Input1.ToLower().ToCharArray();
                var text2 = Input2.ToLower().ToCharArray();
                char temp = ' ';

                for (int i=0; i<text1.Length; i++)
                {
                    for (int j = i+1; j < text1.Length; j++)
                    {
                        if (text1[i] > text1[j])
                        {
                            temp = text1[i];
                            text1[i] = text1[j];
                            text1[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < text2.Length; i++)
                {
                    for (int j = i + 1; j < text2.Length; j++)
                    {
                        if (text2[i] > text2[j])
                        {
                            temp = text2[i];
                            text2[i] = text2[j];
                            text2[j] = temp;
                        }
                    }
                }
                var textOne = new string(text1);
                var textTwo = new string(text2);
                return Array.Equals(textOne, textTwo);
            }
        }
    }
}
