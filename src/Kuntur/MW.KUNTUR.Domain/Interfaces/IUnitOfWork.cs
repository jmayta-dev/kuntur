using MW.KUNTUR.Bio.Domain.Interfaces;
using MW.KUNTUR.Blog.Domain.Interfaces;

namespace MW.KUNTUR.Domain;

public interface IUnitOfWork : IUnitOfWorkBio, IUnitOfWorkBlog
{
    //
    // repositories
    //

    //
    // methods
    //
    Task RollbackAsync(CancellationToken cancellationToken = default);
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
