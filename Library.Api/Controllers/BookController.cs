using System;
using System.Collections.Generic;
using System.Linq;
using Library.Api.Models;
using Library.Api.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers {
    [ApiController]
    [Route("api/authors/{authorId}/books")]
    public class BookController : ControllerBase {
        private IAuthorRepository AuthorRepository { get; }
        private IBookRepository BookRepository { get; }

        public BookController(IBookRepository bookRepository, IAuthorRepository authorRepository) {
            AuthorRepository = authorRepository;
            BookRepository = bookRepository;
        }

        [HttpGet]
        public ActionResult<List<BookDto>> GetBooks(Guid authorId) {
            if (!AuthorRepository.IsAuthorExists(authorId)) {
                return NotFound();
            }

            return BookRepository.GetBooksForAuthor(authorId).ToList();
        }

        [HttpGet("{bookId}", Name = nameof(GetBook))]
        public ActionResult<BookDto> GetBook(Guid authorId, Guid bookId) {
            if (!AuthorRepository.IsAuthorExists(authorId)) {
                return NotFound();
            }

            var book = BookRepository.GetBookForAuthor(authorId, bookId);
            if (book == null) {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public IActionResult AddBook(Guid authorId, BookForCreationDto bookForCreationDto) {
            if (!AuthorRepository.IsAuthorExists(authorId)) {
                return NotFound();
            }

            var book = new BookDto {
                Id = Guid.NewGuid(),
                Title = bookForCreationDto.Title,
                Description = bookForCreationDto.Description,
                Pages = bookForCreationDto.Pages,
                AuthorId = authorId
            };

            BookRepository.AddBook(book);

            return CreatedAtRoute(nameof(GetBook), new {authorId = authorId, bookId = book.Id}, book);
        }

        [HttpDelete("{bookId}")]
        public IActionResult DeleteBook(Guid authorId, Guid bookId) {
            if (!AuthorRepository.IsAuthorExists(authorId)) {
                return NotFound();
            }

            var book = BookRepository.GetBookForAuthor(authorId, bookId);
            if (book == null) return NotFound();

            BookRepository.DeleteBook(book);
            return NoContent();
        }

        [HttpPut("{bookId}")]
        public IActionResult UpdateBook(Guid authorId, Guid bookId, BookForUpdateDto updatedBook) {
            if (!AuthorRepository.IsAuthorExists(authorId)) return NotFound();

            var book = BookRepository.GetBookForAuthor(authorId, bookId);
            if (book == null) return NotFound();

            BookRepository.UpdateBook(authorId, bookId, updatedBook);
            return NoContent();
        }

        [HttpPatch("{bookId}")]
        public IActionResult PartiallyUpdateBook(Guid authorId, Guid bookId,
            JsonPatchDocument<BookForUpdateDto> patchDocument) {
            if (!AuthorRepository.IsAuthorExists(authorId)) return NotFound();
            var book = BookRepository.GetBookForAuthor(authorId, bookId);
            if (book == null) return NotFound();

            var bookToPatch = new BookForUpdateDto {
                Title = book.Title,
                Description = book.Description,
                Pages = book.Pages
            };

            patchDocument.ApplyTo(bookToPatch, ModelState);
            if (!ModelState.IsValid) return BadRequest(ModelState);

            BookRepository.UpdateBook(authorId, bookId, bookToPatch);
            return NoContent();
        }
    }
}