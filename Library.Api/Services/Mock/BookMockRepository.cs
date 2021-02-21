using System;
using System.Collections.Generic;
using System.Linq;
using Library.Api.Data;
using Library.Api.Models;

namespace Library.Api.Services.Mock {
    public class BookMockRepository : IBookMockRepository {
        public IEnumerable<BookDto> GetBooksForAuthor(Guid authorId) {
            return LibraryMockData.Current.Books.Where(item => item.AuthorId == authorId).ToList();
        }

        public BookDto GetBookForAuthor(Guid authorId, Guid bookId) {
            return LibraryMockData.Current.Books.FirstOrDefault(item => item.Id == bookId && item.AuthorId == authorId);
        }

        public void AddBook(BookDto book) {
            LibraryMockData.Current.Books.Add(book);
        }

        public void DeleteBook(BookDto book) {
            LibraryMockData.Current.Books.Remove(book);
        }

        public void UpdateBook(Guid authorId, Guid bookId, BookForUpdateDto book) {
            var originalBook = GetBookForAuthor(authorId, bookId);
            originalBook.Title = book.Title;
            originalBook.Pages = book.Pages;
            originalBook.Description = book.Description;
        }
    }
}