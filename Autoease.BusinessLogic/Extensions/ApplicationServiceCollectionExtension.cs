using Autoease.BusinessLogic.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Autoease.BusinessLogic.Extensions;

public static class ApplicationServiceCollectionExtension
{
    public static IServiceCollection AddApplicationMediator(this IServiceCollection services)
    {
        return services.AddMediatR(x => x.RegisterServicesFromAssemblyContaining<IBaseCommand>());
    }
}

