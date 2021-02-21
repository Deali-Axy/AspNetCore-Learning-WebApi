using System;
using System.Collections.Generic;
using System.Linq;
using Library.Api.Models;
using Library.Api.Services;
using Library.Api.Services.Mock;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers {
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase {
        private IAuthorMockRepository AuthorMockRepository { get; }

        public AuthorController(IAuthorMockRepository authorMockRepository) {
            AuthorMockRepository = authorMockRepository;
        }

        [HttpGet]
        public ActionResult<List<AuthorDto>> GetAuthors() {
            return AuthorMockRepository.GetAuthors().ToList();
        }

        [HttpGet("{authorId}", Name = nameof(GetAuthor))]
        public ActionResult<AuthorDto> GetAuthor(Guid authorId) {
            var author = AuthorMockRepository.GetAuthor(authorId);
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
            AuthorMockRepository.AddAuthor(authorDto);
            return CreatedAtRoute(nameof(GetAuthor), new {authorId = authorDto.Id}, authorDto);
        }

        [HttpDelete("{authorId}")]
        public IActionResult DeleteAuthor(Guid authorId) {
            var author = AuthorMockRepository.GetAuthor(authorId);
            if (author == null) return NotFound();
            
            AuthorMockRepository.DeleteAuthor(author);
            return NoContent();
        }
    }
}