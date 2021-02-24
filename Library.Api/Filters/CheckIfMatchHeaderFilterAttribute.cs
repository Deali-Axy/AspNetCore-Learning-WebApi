using System.Threading.Tasks;
using Library.Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;

namespace Library.Api.Filters {
    /// <summary>
    /// 检查客户端的请求消息头中是否包含If-Match消息头
    /// </summary>
    public class CheckIfMatchHeaderFilterAttribute : ActionFilterAttribute {
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next) {
            if (!context.HttpContext.Request.Headers.ContainsKey(HeaderNames.IfMatch)) {
                context.Result = new BadRequestObjectResult(new ApiError {
                    Message = "必须提供 If-Match 消息头"
                });
            }
            
            return base.OnActionExecutionAsync(context, next);
        }
    }
}