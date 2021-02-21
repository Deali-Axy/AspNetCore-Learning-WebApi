using System.Threading.Tasks;

namespace Library.Api.Services {
    public interface IRepositoryBaseWithId<T, in TId> {
        Task<T> GetByIdAsync(TId id);
        Task<bool> IsExistAsync(TId id);
    }
}