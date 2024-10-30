using Autoease.Api.Models.Request;
using Autoease.BusinessLogic.Commands.User;
using MediatR;

namespace Autoease.Api.Endpoint.Account;

public class RegisterUserEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder builder)
    {
        builder.MapPost("/register", HandlerAsync)
            .Produces(201);
    }

    private static async Task<IResult> HandlerAsync(RegisterUserRequest request, IMediator _mediator)
    {
        var user = new RegisterUserCommand {
            Username = request.Username,
            Email = request.Email,
            Password = request.Password,
            FirstName = request.FirstName,
            LastName = request.LastName,
            UserIdCard = request.UserIdCard,
            Address = request.Address,
            Veichle = request.Veichle
        };

        var result = await _mediator.Send(user);

        if(result.IsValid)
            return TypedResults.Created();

        var errors = result.Errors
            .GroupBy(e => e.PropertyName)
            .ToDictionary(
                g => g.Key,
                g => g.Select(e => e.ErrorMessage).ToArray()
            );

         return TypedResults.ValidationProblem(errors);
    }
}
