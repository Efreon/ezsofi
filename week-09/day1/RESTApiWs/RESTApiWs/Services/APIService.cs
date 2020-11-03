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
        //public JsonResult Calculate(string operation, BodyData data)
        //{
        //    if (operation == "sum")
        //    {
        //        if ( == 1)
        //        {
        //            return 1;
        //        }
        //        else
        //        {
        //            return n + (n - 1);
        //        }
        //    }
        //    else if (operation == "factor")
        //    {
                
        //        for (int i = 1; i < (int)data.Until; i++)
        //        {
        //            result *= i;
        //        }
        //    }
        //    return new JsonResult(new { Result = result });
        //}

    }
}
