using Microsoft.Azure.Cosmos;

namespace MW.KUNTUR.Bio.Persistence.CosmosDb;

public class BioCosmosDbContext
{
    #region Properties & Variables
    //
    // private
    //
    private readonly string _endpoint;
    private readonly string _primaryKey;
    private readonly List<string> _containers = [];
    private readonly CosmosClient _cosmosClient;
    private readonly Container _container;
    private readonly Database _database;
    #endregion

    #region Constructor
    public BioCosmosDbContext(dynamic configuration)
    {
        _endpoint = configuration.GetValue<string>("BioCosmosDb__EndPoint");
        _primaryKey = configuration.GetValue<string>("BioCosmosDb__PrimaryKey");

        _containers.AddRange(["Person", "Job", "SocialNetwork"]);
        _cosmosClient = new CosmosClient(_endpoint, _primaryKey);
    }
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
    #endregion
}