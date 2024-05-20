namespace MW.KUNTUR.Bio.Domain.Interfaces;

public interface IUnitOfWorkBio : IDisposable
{
    //
    // repository
    //

    //
    // methods
    //
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}