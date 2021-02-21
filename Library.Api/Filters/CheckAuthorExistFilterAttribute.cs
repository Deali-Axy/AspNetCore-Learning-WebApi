using System;
using System.Linq;
using System.Threading.Tasks;
using Library.Api.Services;
using Library.Api.Services.Impl;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Library.Api.Filters {
    /// <summary>
    /// 检查作者是否存在的过滤器
    /// </summary>
    public class CheckAuthorExistFilterAttribute : ActionFilterAttribute {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public CheckAuthorExistFilterAttribute(IRepositoryWrapper repositoryWrapper) {
            _repositoryWrapper = repositoryWrapper;
        }

        public override async Task
            OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next) {
            var authorIdParameter =
                context.ActionArguments.Single(m => m.Key == "authorId");
            var authorId = (Guid) authorIdParameter.Value;
            var isExist = await _repositoryWrapper.Author.IsExistAsync(authorId);
            if (!isExist) {
                context.Result = new NotFoundResult();
            }

            await base.OnActionExecutionAsync(context, next);
        }
    }
}