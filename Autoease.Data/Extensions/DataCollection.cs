using Autoease.Data.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Autoease.Data.Extensions;

public static class DataCollection
{
    public static IServiceCollection AddDataService(
        this IServiceCollection services, 
        Action<DbContextOptionsBuilder> action
    )
    {
        services.AddDbContext<AppDbContext>(action);

        return services;
    }
}
