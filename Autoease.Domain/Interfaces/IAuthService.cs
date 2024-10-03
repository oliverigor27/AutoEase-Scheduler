namespace Autoease.Domain.Interfaces;

public interface IAuthService
{
    Task<string> SignIn();
}