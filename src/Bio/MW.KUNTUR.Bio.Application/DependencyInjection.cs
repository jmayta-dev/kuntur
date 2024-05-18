using Microsoft.Extensions.DependencyInjection;

namespace MW.KUNTUR.Bio.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        var applicationAssembly = typeof(DependencyInjection).Assembly;
        services.AddMediatR(config => config.RegisterServicesFromAssembly(applicationAssembly));

        return services;
    }
}