using Microsoft.Azure.Cosmos;
using MW.KUNTUR.Bio.Domain.Entities;
using MW.KUNTUR.Bio.Domain.Interfaces;

namespace MW.KUNTUR.Bio.Persistence.CosmosDb.Repositories;

public class PersonRepository : IPersonRepository
{
    #region Properties & Variables
    //
    // private
    //
    private readonly Container _container;
    private readonly TransactionalBatch _batch;
    //
    // public
    //
    #endregion

    #region Constructor
    public PersonRepository(Container container)
    {
        _container = container;
        PartitionKey partitionKey = new("/personId");
        _batch = _container.CreateTransactionalBatch(partitionKey);
    }
    #endregion

    #region Methods
    public async Task CreatePersonAsync(Person person, CancellationToken cancellationToken = default)
    {
        await Task.Run(() => _batch.CreateItem<Person>(person));
    }
    #endregion

}