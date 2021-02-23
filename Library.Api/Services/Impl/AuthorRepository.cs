using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Library.Api.Entities;
using Library.Api.Extensions;
using Library.Api.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Services.Impl {
    public class AuthorRepository : RepositoryBase<Author, Guid>, IAuthorRepository {
        private Dictionary<string, PropertyMapping> _mappingDict = null;

        public AuthorRepository(DbContext context) : base(context) {
            _mappingDict = new Dictionary<string, PropertyMapping>(StringComparer.OrdinalIgnoreCase);
            _mappingDict.Add("name", new PropertyMapping("Name"));
            _mappingDict.Add("age", new PropertyMapping("BirthDate", true));
            _mappingDict.Add("BirthPlace", new PropertyMapping("BirthPlace"));
        }

        public Task<PagedList<Author>> GetAllAsync(AuthorResourceParameters parameters) {
            IQueryable<Author> queryableAuthors = DbContext.Set<Author>();
            // 过滤
            if (!string.IsNullOrWhiteSpace(parameters.BirthPlace))
                queryableAuthors = queryableAuthors.Where(author =>
                    author.BirthPlace.ToLower() == parameters.BirthPlace.ToLower());

            // 搜索
            if (!string.IsNullOrWhiteSpace(parameters.SearchQuery))
                queryableAuthors = queryableAuthors.Where(author =>
                    author.BirthPlace.ToLower().Contains(parameters.SearchQuery.ToLower()) ||
                    author.Name.ToLower().Contains(parameters.SearchQuery.ToLower()));

            // 排序
            // queryableAuthors = queryableAuthors.OrderBy(parameters.SortBy);
            // 排序（使用扩展方法 实现属性映射）
            queryableAuthors = queryableAuthors.Sort(parameters.SortBy, _mappingDict);

            // 分页
            return PagedList<Author>.CreateAsync(queryableAuthors, parameters.PageNumber, parameters.PageSize);
        }
    }
}