using System;
using System.Collections.Generic;
using Library.Api.Models;

namespace Library.Api.Services.Mock {
    public interface IBookMockRepository {
        IEnumerable<BookDto> GetBooksForAuthor(Guid authorId);
        BookDto GetBookForAuthor(Guid authorId, Guid bookId);
        void AddBook(BookDto book);
        void DeleteBook(BookDto book);
        void UpdateBook(Guid authorId, Guid bookId, BookForUpdateDto book);
    }
}