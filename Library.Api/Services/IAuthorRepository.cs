using System;
using Library.Api.Entities;

namespace Library.Api.Services {
    public interface IAuthorRepository : IRepositoryBase<Author>, IRepositoryBaseWithId<Author,Guid> {
        
    }
}