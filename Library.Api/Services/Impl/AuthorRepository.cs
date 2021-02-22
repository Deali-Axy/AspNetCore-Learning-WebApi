using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Library.Api.Entities;
using Library.Api.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Services.Impl {
    public class AuthorRepository : RepositoryBase<Author, Guid>, IAuthorRepository {
        public AuthorRepository(DbContext context) : base(context) {
        }

        public Task<PagedList<Author>> GetAllAsync(AuthorResourceParameters parameters) {
            IQueryable<Author> queryableAuthors = DbContext.Set<Author>();
            return PagedList<Author>.CreateAsync(queryableAuthors, parameters.PageNumber, parameters.PageSize);
        }
    }
}