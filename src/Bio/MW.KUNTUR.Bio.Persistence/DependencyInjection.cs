
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MW.KUNTUR.Bio.Persistence.CosmosDb;

namespace MW.KUNTUR.Bio.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceLayer(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;

        services.TryAddScoped<BioDbContext>();

        return services;
    }
}