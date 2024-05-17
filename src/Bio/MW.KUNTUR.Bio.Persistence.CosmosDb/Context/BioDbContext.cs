using Microsoft.Extensions.Configuration;

namespace MW.KUNTUR.Bio.Persistence.CosmosDb;

public class BioDbContext
{
    #region Properties & Variables
    //
    // private
    //
    private readonly string? _endpoint;
    private readonly string? _primaryKey;
    #endregion

    #region Constructor
    public BioDbContext(IConfiguration configuration)
    {
        _endpoint = configuration.GetValue<string>("CosmosDb__endPoint");
        _primaryKey = configuration.GetValue<string>("CosmosDb__primaryKey");
        if (_endpoint is null || _primaryKey is null)
        {
            throw new ArgumentException("CosmosDB credentials are invalid.");
        }
    }
    #endregion

    #region Events
    #endregion

    #region Methods
    #endregion
}