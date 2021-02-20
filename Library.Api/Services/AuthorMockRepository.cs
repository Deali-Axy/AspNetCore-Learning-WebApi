using System;
using System.Collections.Generic;
using System.Linq;
using Library.Api.Data;
using Library.Api.Models;

namespace Library.Api.Services {
    public class AuthorMockRepository : IAuthorRepository {
        public IEnumerable<AuthorDto> GetAuthors() {
            return LibraryMockData.Current.Authors;
        }

        public AuthorDto GetAuthor(Guid authorId) {
            return LibraryMockData.Current.Authors.FirstOrDefault(item => item.Id == authorId);
        }

        public bool IsAuthorExists(Guid authorId) {
            return LibraryMockData.Current.Authors.Any(item => item.Id == authorId);
        }
    }
}