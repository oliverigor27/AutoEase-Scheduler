using Autoease.Api.Endpoint;
using Autoease.Api.Endpoint.Account;

namespace Autoease.Api.Extensions;

public static class EndpointBuilder
{
    public static WebApplication UseEndpoints(this WebApplication application)
    {
        var builder = application.MapGroup("");
        UserAccount(builder);
        return application;
    }

    private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(
    this IEndpointRouteBuilder app) where TEndpoint : IEndpoint
    {
        TEndpoint.Map(app);
        return app;
    }

    public static void UserAccount(IEndpointRouteBuilder builder)
    {
        builder.MapGroup("/account")
            .WithTags("Accounts")
            .MapEndpoint<RegisterUserEndpoint>();
    }
}
