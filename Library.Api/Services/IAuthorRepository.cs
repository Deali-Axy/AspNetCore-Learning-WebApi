using System;
using System.Collections.Generic;
using Library.Api.Models;

namespace Library.Api.Services {
    public interface IAuthorRepository {
        IEnumerable<AuthorDto> GetAuthors();
        AuthorDto GetAuthor(Guid authorId);
        bool IsAuthorExists(Guid authorId);
    }
}