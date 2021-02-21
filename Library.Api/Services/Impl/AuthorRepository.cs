using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Library.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Services.Impl {
    public class AuthorRepository : RepositoryBase<Author, Guid>, IAuthorRepository {
        public AuthorRepository(DbContext context) : base(context) {
        }
    }
}