using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MW.KUNTUR.Bio.Domain.Interfaces;
using MW.KUNTUR.Bio.Persistence.CosmosDb;
using MW.KUNTUR.Bio.Persistence.CosmosDb.Repositories;

namespace MW.KUNTUR.Bio.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceLayer(this IServiceCollection services)
    {
        services.AddServices();
        return services;
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.TryAddScoped<BioDbContext>();
        services.TryAddTransient<IUnitOfWorkBio, UnitOfWorkBio>();
    }
}