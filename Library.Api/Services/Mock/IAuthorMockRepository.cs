using System;
using System.Collections.Generic;
using Library.Api.Models;

namespace Library.Api.Services.Mock {
    public interface IAuthorMockRepository {
        IEnumerable<AuthorDto> GetAuthors();
        AuthorDto GetAuthor(Guid authorId);
        bool IsAuthorExists(Guid authorId);
        void AddAuthor(AuthorDto author);
        void DeleteAuthor(AuthorDto author);
    }
}