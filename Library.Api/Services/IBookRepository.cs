using System;
using System.Collections.Generic;
using Library.Api.Models;

namespace Library.Api.Services {
    public interface IBookRepository {
        IEnumerable<BookDto> GetBooksForAuthor(Guid authorId);
        BookDto GetBookForAuthor(Guid authorId, Guid bookId);
    }
}