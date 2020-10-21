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

        private readonly Printer MyPrinter;
        private readonly IColor MyColor;
        public ConsoleLoggerMiddleware(Printer printer, IColor myColor)
        {
            MyPrinter = printer;
            MyColor = myColor;
        }


        // private readonly RequestDelegate _next;
        //public ConsoleLoggerMiddleware(RequestDelegate next)
        //{
        //    _next = next;
        //}

        //public Task Invoke(HttpContext httpContext)
        //{

        //    return _next(httpContext);
        //}
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            MyPrinter.Log("dasdfasfsd");
            MyColor.PrintColor();
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
