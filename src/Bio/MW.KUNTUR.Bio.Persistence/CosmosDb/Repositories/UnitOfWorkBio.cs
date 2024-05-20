using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;
using MW.KUNTUR.Bio.Domain.Interfaces;

namespace MW.KUNTUR.Bio.Persistence.CosmosDb.Repositories;

public class UnitOfWorkBio : IUnitOfWorkBio
{
    #region Properties & Variables
    //
    // private
    //
    private bool _disposed = false;
    private Task _initializationTask = null!;
    private TransactionalBatch _batch;
    private readonly string BIO_PARTITION_KEY = "/personId";

    // repositories
    private IJobRepository? _jobRepository;
    private IPersonRepository? _personRepository;
    private ISocialNetworkRepository? _socialNetworkRepository;

    // containers
    private Container _jobContainer;
    private Container _personContainer;
    private Container _socialNetworkContainer;
    private IEnumerable<Container> _containers;
    private readonly BioDbContext _context;
    //
    // public
    //
    public IJobRepository JobRepository
    {
        get
        {
            PartitionKey partitionKey = new(BIO_PARTITION_KEY);
            _batch = _jobContainer.CreateTransactionalBatch(partitionKey);
            return _jobRepository ??= new JobRepository(_jobContainer);
        }
    }

    public IPersonRepository PersonRepository
    {
        get
        {
            PartitionKey partitionKey = new(BIO_PARTITION_KEY);
            _batch = _personContainer.CreateTransactionalBatch(partitionKey);
            return _personRepository ??= new PersonRepository(_personContainer);
        }
    }
    public ISocialNetworkRepository SocialNetworkRepository => throw new NotImplementedException();

    public Container JobContainer => _jobContainer;
    #endregion

    #region Constructor
    public UnitOfWorkBio(BioDbContext context, IConfiguration configuration)
    {
        _context = context;

        // Asyncronous Initialization
        _initializationTask = InitializeAsync();
    }
    #endregion

    #region Disposable Support
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed && disposing)
            _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    #endregion

    #region Methods
    private async Task InitializeAsync()
    {
        _jobContainer =
            await _context.GetOrCreateContainer("Job", BIO_PARTITION_KEY);

        _personContainer =
            await _context.GetOrCreateContainer("Person", BIO_PARTITION_KEY);

        _socialNetworkContainer =
            await _context.GetOrCreateContainer("SocialNetwork", BIO_PARTITION_KEY);
    }

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _initializationTask;
        var container = await _context.GetOrCreateContainer("Job", "/personId");
        PartitionKey partitionKey = new("road-bikes");
        TransactionalBatch batch = container.CreateTransactionalBatch(partitionKey);
        await batch.ExecuteAsync(cancellationToken);
        throw new NotImplementedException();
    }
    #endregion





}