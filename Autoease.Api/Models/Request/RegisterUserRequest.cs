using Autoease.Domain.AggregateModel.UserAggregate;

namespace Autoease.Api.Models.Request;

public class RegisterUserRequest
{
    public string UserIdCard { get; set; } = null!;
    public string Username { get;  set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public Address Address { get; set; } = null!;
    public ICollection<Veichle> Veichle { get; set; } = null!;
}
