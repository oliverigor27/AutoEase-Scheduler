using Autoease.BusinessLogic.Extensions;
using Autoease.Data.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Autoease.Api.Extensions;

public static class ApiCollections
{

    public static WebApplicationBuilder AddDatabaseContext(this WebApplicationBuilder builder)
    {
        builder.Services.AddDataService(x => x.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

        return builder;
    }

    public static WebApplicationBuilder AddAutoeaseServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddApplicationMediator();
        return builder;
    }
}
