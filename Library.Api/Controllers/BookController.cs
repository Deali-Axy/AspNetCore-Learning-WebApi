using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using AutoMapper;
using Library.Api.Entities;
using Library.Api.Filters;
using Library.Api.Helpers;
using Library.Api.Models;
using Library.Api.Services;
using Library.Api.Services.Impl;
using Library.Api.Services.Mock;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace Library.Api.Controllers {
    [ApiController]
    [Route("api/authors/{authorId}/books")]
    [ServiceFilter(typeof(CheckAuthorExistFilterAttribute))]
    public class BookController : ControllerBase {
        private IRepositoryWrapper _repositoryWrapper;
        private IMapper _mapper;

        public BookController(IRepositoryWrapper repositoryWrapper, IMapper mapper) {
            _repositoryWrapper = repositoryWrapper;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetBooksAsync(Guid authorId) {
            var books = await _repositoryWrapper.Book.GetBooksAsync(authorId);
            var bookDtoList = _mapper.Map<IEnumerable<BookDto>>(books);
            return bookDtoList.ToList();
        }

        [HttpGet("{bookId}", Name = nameof(GetBookAsync))]
        [ResponseCache(CacheProfileName = "Default")]
        public async Task<ActionResult<BookDto>> GetBookAsync(Guid authorId, Guid bookId) {
            var book = await _repositoryWrapper.Book.GetBookAsync(authorId, bookId);
            if (book == null) return NotFound();

            var bookDto = _mapper.Map<BookDto>(book);
            return bookDto;
        }

        [HttpPost]
        public async Task<IActionResult> AddBookAsync(Guid authorId, BookForCreationDto bookForCreationDto) {
            var book = _mapper.Map<Book>(bookForCreationDto);
            book.AuthorId = authorId;
            _repositoryWrapper.Book.Create(book);

            if (!await _repositoryWrapper.Book.SaveAsync())
                throw new Exception("创建资源 book 失败");

            var bookDto = _mapper.Map<BookDto>(book);
            return CreatedAtRoute(nameof(GetBookAsync), new {authorId = authorId, bookId = bookDto.Id}, bookDto);
        }

        [HttpDelete("{bookId}")]
        public async Task<IActionResult> DeleteBookAsync(Guid authorId, Guid bookId) {
            var book = await _repositoryWrapper.Book.GetBookAsync(authorId, bookId);
            if (book == null) return NotFound();

            _repositoryWrapper.Book.Delete(book);
            var result = await _repositoryWrapper.Book.SaveAsync();
            if (!result) throw new Exception("删除资源失败");

            return NoContent();
        }

        [HttpPut("{bookId}")]
        [CheckIfMatchHeaderFilter]
        public async Task<IActionResult> UpdateBookAsync(Guid authorId, Guid bookId, BookForUpdateDto updatedBook) {
            var book = await _repositoryWrapper.Book.GetBookAsync(authorId, bookId);
            if (book == null) return NotFound();

            // 获取 ETag
            var entityHash = HashFactory.GetHash(book);
            if (Request.Headers.TryGetValue(HeaderNames.IfMatch, out var requestETag)
                && requestETag != entityHash) {
                return StatusCode(StatusCodes.Status412PreconditionFailed);
            }

            _mapper.Map(updatedBook, book, typeof(BookForUpdateDto), typeof(Book));
            _repositoryWrapper.Book.Update(book);
            if (!await _repositoryWrapper.Book.SaveAsync()) throw new Exception("更新资源失败");

            // 更新 ETag
            entityHash = HashFactory.GetHash(book);
            Response.Headers[HeaderNames.IfMatch] = entityHash;

            return NoContent();
        }

        [HttpPatch("{bookId}")]
        [CheckIfMatchHeaderFilter]
        public async Task<IActionResult> PartiallyUpdateBookAsync(Guid authorId,
            Guid bookId,
            JsonPatchDocument<BookForUpdateDto> patchDocument) {
            var book = await _repositoryWrapper.Book.GetBookAsync(authorId, bookId);
            if (book == null) return NotFound();

            var bookUpdateDto = _mapper.Map<BookForUpdateDto>(book);
            patchDocument.ApplyTo(bookUpdateDto, ModelState);
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _mapper.Map(bookUpdateDto, book, typeof(BookForUpdateDto), typeof(Book));
            _repositoryWrapper.Book.Update(book);
            if (!await _repositoryWrapper.Book.SaveAsync()) throw new Exception("更新资源失败");

            return NoContent();
        }
    }
}