using System.Text;
using Library.Api.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Library.Api.Filters {
    public class JsonExceptionFilter : IExceptionFilter {
        private readonly IWebHostEnvironment _env;
        private readonly ILogger _logger;

        public JsonExceptionFilter(IWebHostEnvironment env,ILogger<Program> logger) {
            _env = env;
            _logger = logger;
        }
        
        public void OnException(ExceptionContext context) {
            var error = new ApiError();
            if (_env.IsDevelopment()) {
                error.Message = context.Exception.Message;
                error.Detail = context.Exception.ToString();
            }
            else {
                error.Message = "服务器出错";
                error.Detail = context.Exception.Message;
            }

            context.Result = new ObjectResult(error) {
                StatusCode = StatusCodes.Status500InternalServerError
            };
            
            var sb = new StringBuilder();
            sb.AppendLine($"服务发生异常：{context.Exception.Message}");
            sb.AppendLine(context.Exception.ToString());
            _logger.LogCritical(sb.ToString());
        }
    }
}