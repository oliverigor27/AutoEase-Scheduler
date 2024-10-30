using Autoease.BusinessLogic.Extensions;

namespace Autoease.Api.Extensions;

public static class ApiCollections
{
    public static WebApplicationBuilder AddAutoeaseServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddApplicationMediator();
        return builder;
    }
}
