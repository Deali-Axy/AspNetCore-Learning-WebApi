namespace Library.Api.Services {
    /// <summary>
    /// 仓储包装器接口
    /// </summary>
    public interface IRepositoryWrapper {
        IBookRepository Book { get; }
        IAuthorRepository Author { get; }
    }
}