using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Configuration;

namespace MW.KUNTUR.Bio.Persistence.CosmosDb;

public class BioCosmosDbContext
{
    #region Properties & Variables
    //
    // private
    //
    private readonly string? _endpoint;
    private readonly string? _primaryKey;
    private readonly IConfiguration _configuration;
    private readonly CosmosClient _client;
    private readonly Container _container;
    private Database _database;
    //
    // public
    //
    public Container Container => _container;
    #endregion

    #region Constructor
    public BioCosmosDbContext(IConfiguration configuration)
    {
        _configuration =
            configuration ??
            throw new ArgumentNullException(nameof(configuration));

        _endpoint =
            _configuration["BioCosmosDb__EndPoint"] ??
            throw new InvalidOperationException("");

        _primaryKey =
            _configuration["BioCosmosDb__PrimaryKey"] ??
            throw new InvalidOperationException("");

        _client = new CosmosClient(_endpoint, _primaryKey);

    }

    public BioCosmosDbContext() { }
    #endregion

    #region Events
    #endregion

    #region Methods
    /*
        // EndPoint
        // Primary Key
        // BD
        // Colección
        // Cliente
    */
    public static async Task<Database> GetDb()
    {
        var instance = new BioCosmosDbContext();
        Database db = await instance._client.CreateDatabaseIfNotExistsAsync("Kuntur");
        Container cn = await db.CreateContainerIfNotExistsAsync("");
        return db;
    }
    #endregion
}