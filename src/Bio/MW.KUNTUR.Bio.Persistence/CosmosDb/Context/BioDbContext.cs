using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;

namespace MW.KUNTUR.Bio.Persistence.CosmosDb;

public class BioDbContext
{
    #region Properties & Variables
    //
    // private
    //
    private Container _container;
    private Database _database;
    private readonly string? _databaseId;
    private readonly string? _endpoint;
    private readonly string? _primaryKey;
    private readonly Task _initializationTask = null!;
    //
    // public
    //
    public Container Container => _container;
    #endregion

    #region Constructor
    public BioDbContext(IConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(configuration, nameof(configuration));

        _endpoint =
            configuration["CosmosDb__Bio__EndPoint"] ??
            throw new InvalidOperationException(
                "Please specify a valid CosmosDB EndPoint in the settings.");

        _primaryKey =
            configuration["CosmosDb__Bio__PrimaryKey"] ??
            throw new InvalidOperationException(
                "Please specify a valid CosmosDB PrimaryKey in the settings.");

        _databaseId =
            configuration["CosmosDb__Bio__Database"] ??
            throw new InvalidOperationException(
                "CosmosDB's \"database id\" not found in the settings.");

        // Asyncronous Initialization
        _initializationTask = InitializeAsync();
    }
    #endregion

    #region Methods
    //
    // private methods
    //
    private async Task InitializeAsync()
    {
        if (_container is not null)
            return;

        CosmosClient client = new(_endpoint, _primaryKey);
        Database database = await client.CreateDatabaseIfNotExistsAsync(_databaseId);
        ContainerProperties containerProperties = new("Person", "/PersonId");
        _container = await database.CreateContainerIfNotExistsAsync(
            containerProperties: containerProperties,
            throughput: 400
        );
    }
    //
    // public methods
    //
    public async Task<Container> GetOrCreateContainer(
        string containerId, string partitionKey, int throughput = 400)
    {
        return await _database.CreateContainerIfNotExistsAsync(containerId, partitionKey, throughput);
    }
    #endregion
}