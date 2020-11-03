using System;
using System.Collections.Generic;
using System.Linq;
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
            for (int i=0; i< numbers.Length; i++)
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
                resultArray[i] = numbers[i]*2;
            }
            return resultArray;
        }

    }
}
