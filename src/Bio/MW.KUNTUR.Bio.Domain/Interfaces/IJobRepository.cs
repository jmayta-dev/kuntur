using MW.KUNTUR.Bio.Domain.Entities;

namespace MW.KUNTUR.Bio.Domain.Interfaces;

public interface IJobRepository
{
    Task CreateJob(Job job, CancellationToken cancellationToken = default);
}