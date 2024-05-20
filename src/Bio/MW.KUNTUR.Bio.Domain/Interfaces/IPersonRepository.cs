using MW.KUNTUR.Bio.Domain.Entities;

namespace MW.KUNTUR.Bio.Domain.Interfaces;

public interface IPersonRepository
{
    Task CreatePersonAsync(Person person, CancellationToken cancellationToken = default);
}