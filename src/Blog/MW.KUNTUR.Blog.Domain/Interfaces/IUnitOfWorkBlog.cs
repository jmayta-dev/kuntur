namespace MW.KUNTUR.Blog.Domain.Interfaces;

public interface IUnitOfWorkBlog : IDisposable
{
    IBlogRepository BlogRepository { get; }

    Task RollbackAsync(CancellationToken cancellationToken = default);
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}