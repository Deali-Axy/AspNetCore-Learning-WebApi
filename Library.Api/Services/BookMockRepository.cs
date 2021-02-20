using System;
using System.Collections.Generic;
using System.Linq;
using Library.Api.Data;
using Library.Api.Models;

namespace Library.Api.Services {
    public class BookMockRepository : IBookRepository {
        public IEnumerable<BookDto> GetBooksForAuthor(Guid authorId) {
            return LibraryMockData.Current.Books.Where(item => item.AuthorId == authorId).ToList();
        }

        public BookDto GetBookForAuthor(Guid authorId, Guid bookId) {
            return LibraryMockData.Current.Books.FirstOrDefault(item => item.Id == bookId && item.AuthorId == authorId);
        }
    }
}