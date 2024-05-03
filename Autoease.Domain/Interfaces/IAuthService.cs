using Autoease.Domain.Dto;

namespace Autoease.Domain.Interfaces;

public interface IAuthService
{
    Task<string> SignIn(AuthDto login);
}