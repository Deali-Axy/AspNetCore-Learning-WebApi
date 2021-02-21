using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Library.Api.Middlewares {
    public class PrintRequestMiddleware {
        private readonly RequestDelegate _next;

        public PrintRequestMiddleware(RequestDelegate requestDelegate, IWebHostEnvironment env) {
            _next = requestDelegate;
        }

        public Task Invoke(HttpContext context) {
            var request = context.Request;
            var response = context.Response;
            var url = request.Host + request.Path;
            var dateTimeStr = $"{DateTime.Now.ToLongDateString()}_{DateTime.Now.ToLongTimeString()}";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"[{dateTimeStr}] \"{request.Method} {url}\" " +
                              $"{response.StatusCode} {response.ContentLength}");
            Console.ResetColor();
            return _next(context);
        }
    }
}