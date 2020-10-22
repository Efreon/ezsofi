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
        private readonly RequestDelegate _next;
        // private readonly PrinterService PrinterService;
        private IColor ColorService { get; set; }
        //public ConsoleLoggerMiddleware(Printer printer, IColor ColorService)
        //{
        //    MyPrinter = printer;
        //    MyColor = myColor;
        //}

        public ConsoleLoggerMiddleware(RequestDelegate next, IColor colorService)
        {
            _next = next;
            ColorService = colorService;
        }
        //public ConsoleLoggerMiddleware(RequestDelegate next, IEnumerable<IColor> colorService)
        //{
        //    _next = next;
        //    ColorService = colorService;
        //}

        //public Task Invoke(HttpContext httpContext)
        //{

        //    return _next(httpContext);
        //}
        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // Console.WriteLine("Hi from the middleware");
            // MyPrinter.Log("dasdfasfsd");
            ColorService.PrintColor();
            return next(context);
        }
    }

    //// Extension method used to add the middleware to the HTTP request pipeline.
    //public static class ConsoleLoggerMiddlewareExtensions
    //{
    //    public static IApplicationBuilder UseConsoleLoggerMiddleware(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<ConsoleLoggerMiddleware>();
    //    }
    //}
}
