using System;
using System.Threading.Tasks;
using Library.Api.Entities;
using Library.Api.Helpers;

namespace Library.Api.Services {
    public interface IAuthorRepository : IRepositoryBase<Author>, IRepositoryBaseWithId<Author, Guid> {
        Task<PagedList<Author>> GetAllAsync(AuthorResourceParameters parameters);
    }
}