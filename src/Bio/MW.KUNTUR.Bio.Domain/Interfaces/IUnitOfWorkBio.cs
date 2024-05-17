namespace MW.KUNTUR.Bio.Domain.Interfaces;

public interface IUnitOfWorkBio : IDisposable
{
    //
    // repository
    //
    IBioRepository BioRepository { get; }
    //
    // methods
    //
    Task RollbackAsync(CancellationToken cancellationToken = default);
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}