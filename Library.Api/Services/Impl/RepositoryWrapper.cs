using Library.Api.Entities;

namespace Library.Api.Services.Impl {
    public class RepositoryWrapper : IRepositoryWrapper {
        private IAuthorRepository _authorRepository = null;
        private IBookRepository _bookRepository = null;

        public RepositoryWrapper(LibraryDbContext dbContext) {
            LibraryDbContext = dbContext;
        }

        public IBookRepository Book {
            get {
                _bookRepository ??= new BookRepository(LibraryDbContext);
                return _bookRepository;
            }
        }

        public IAuthorRepository Author {
            get {
                _authorRepository ??= new AuthorRepository(LibraryDbContext);
                return _authorRepository;
            }
        }

        private LibraryDbContext LibraryDbContext { get; }
    }
}