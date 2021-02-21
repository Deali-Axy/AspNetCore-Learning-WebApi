using System;
using Library.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Services.Impl {
    public class BookRepository : RepositoryBase<Book, Guid>, IBookRepository {
        public BookRepository(DbContext context) : base(context) {
        }
    }
}