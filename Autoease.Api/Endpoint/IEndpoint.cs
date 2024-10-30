namespace Autoease.Api.Endpoint;

public interface IEndpoint
{
    static abstract void Map(IEndpointRouteBuilder builder);
}
