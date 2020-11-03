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
        // public JsonResult Calculate(string operation, BodyData data);
        public int? Sum(int? num);
        public int? Factorial(int? number);
    }
}
