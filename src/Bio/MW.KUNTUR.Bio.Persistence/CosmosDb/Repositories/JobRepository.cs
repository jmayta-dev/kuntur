using Microsoft.Azure.Cosmos;
using MW.KUNTUR.Bio.Domain.Entities;
using MW.KUNTUR.Bio.Domain.Interfaces;

namespace MW.KUNTUR.Bio.Persistence.CosmosDb.Repositories;

public class JobRepository : IJobRepository
{
    private readonly TransactionalBatch _batch;
    private readonly Container _container;

    public JobRepository(Container container)
    {
        _container = container;
        PartitionKey partitionKey = new("/personId");
        _batch = _container.CreateTransactionalBatch(partitionKey);
    }


    #region Methods
    public async Task CreateJob(Job job, CancellationToken cancellationToken = default)
    {
        _batch.CreateItem<Job>(job);
    }
    #endregion
}