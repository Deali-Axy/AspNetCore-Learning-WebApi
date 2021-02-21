using System;
using Library.Api.Entities;

namespace Library.Api.Services {
    public interface IBookRepository : IRepositoryBase<Book>, IRepositoryBaseWithId<Book,Guid> {
        
    }
}