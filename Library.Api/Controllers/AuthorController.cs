using System.Collections.Generic;
using System.Linq;
using Library.Api.Models;
using Library.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase {
        private IAuthorRepository AuthorRepository { get; }

        public AuthorController(IAuthorRepository authorRepository) {
            AuthorRepository = authorRepository;
        }

        [HttpGet]
        public ActionResult<List<AuthorDto>> GetAuthors() {
            return AuthorRepository.GetAuthors().ToList();
        }
        
        
    }
}