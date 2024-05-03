using Autoease.Domain.Dto;

namespace Autoease.Domain.Interfaces;

public interface IAuthService
{
    Task<bool> SignIn(AuthDto login);
}