using Microsoft.AspNetCore.Mvc;
using RESTApiWs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTApiWs.Services
{
    public interface IAPIService
    {

        public int? Sum(int? num);
        public int? Factorial(int? number);
        public int? SumArray(int[] numbers);
        public int? MultiplyArray(int[] numbers);
        public int[] DoubleArray(int[] numbers);
        public string YodaSpeak(string text);
    }
}
