using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloDIProject.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace HelloDIProject
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ConsoleLoggerMiddleware : IMiddleware
    {

        private Printer MyPrinter;
        public ConsoleLoggerMiddleware(Printer printer)
        {
            MyPrinter = printer;
        }


        private readonly RequestDelegate _next;
        public ConsoleLoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //public Task Invoke(HttpContext httpContext)
        //{

        //    return _next(httpContext);
        //}
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            MyPrinter.Log("dasdfasfsd");

            return next(context);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ConsoleLoggerMiddlewareExtensions
    {
        public static IApplicationBuilder UseConsoleLoggerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ConsoleLoggerMiddleware>();
        }
    }
}
