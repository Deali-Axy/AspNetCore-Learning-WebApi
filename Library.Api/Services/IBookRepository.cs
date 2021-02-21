using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Api.Entities;

namespace Library.Api.Services {
    public interface IBookRepository : IRepositoryBase<Book>, IRepositoryBaseWithId<Book,Guid> {
        Task<IEnumerable<Book>> GetBooksAsync(Guid authorId);
        Task<Book> GetBookAsync(Guid authorId, Guid bookId);
    }
}