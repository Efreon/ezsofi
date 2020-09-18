using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NumnSum
{
    public class Sum
    {
        public List<int> Numbers = new List<int>();

        public Sum(List<int> numbers)
        {
            Numbers = numbers;
        }

        public int getSum()
        {
            int totalSum = 0;
            if (Numbers == null)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    totalSum += Numbers[i];
                }
                return totalSum;
            }
            
        }
    }
}
