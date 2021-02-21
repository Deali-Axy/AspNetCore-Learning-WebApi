using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Services.Impl {
    public class BookRepository : RepositoryBase<Book, Guid>, IBookRepository {
        public BookRepository(DbContext context) : base(context) {
        }

        public Task<IEnumerable<Book>> GetBooksAsync(Guid authorId) {
            return Task.FromResult(DbContext.Set<Book>().Where(book => book.AuthorId == authorId).AsEnumerable());
        }

        public async Task<Book> GetBookAsync(Guid authorId, Guid bookId) {
            return await DbContext.Set<Book>()
                .SingleOrDefaultAsync(book => book.AuthorId == authorId && book.Id == bookId);
        }
    }
}