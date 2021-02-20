using System;
using System.Collections.Generic;
using System.Linq;
using Library.Api.Models;
using Library.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers {
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase {
        private IAuthorRepository AuthorRepository { get; }

        public AuthorController(IAuthorRepository authorRepository) {
            AuthorRepository = authorRepository;
        }

        [HttpGet]
        public ActionResult<List<AuthorDto>> GetAuthors() {
            return AuthorRepository.GetAuthors().ToList();
        }

        [HttpGet("{authorId}", Name = nameof(GetAuthor))]
        public ActionResult<AuthorDto> GetAuthor(Guid authorId) {
            var author = AuthorRepository.GetAuthor(authorId);
            if (author == null) {
                return NotFound();
            }

            return author;
        }

        [HttpPost]
        public IActionResult CreateAuthor(AuthorForCreationDto authorForCreationDto) {
            var authorDto = new AuthorDto {
                Name = authorForCreationDto.Name,
                Age = authorForCreationDto.Age,
                Email = authorForCreationDto.Email
            };
            AuthorRepository.AddAuthor(authorDto);
            return CreatedAtRoute(nameof(GetAuthor), new {authorId = authorDto.Id}, authorDto);
        }

        [HttpDelete("{authorId}")]
        public IActionResult DeleteAuthor(Guid authorId) {
            var author = AuthorRepository.GetAuthor(authorId);
            if (author == null) return NotFound();
            
            AuthorRepository.DeleteAuthor(author);
            return NoContent();
        }
    }
}