using Autoease.Domain.Dto;
using Autoease.Domain.Interfaces;
using Autoease.Infrastructure.Claims;
using Autoease.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Autoease.Application.Service.Auth;

public class AuthService : IAuthService
{
    private readonly IConfiguration _configuration;
    private readonly DatabaseContext _databaseContext;
    private readonly ClaimsService _claimsService;

    public AuthService(
        IConfiguration configuration, 
        DatabaseContext databaseContext,
        ClaimsService claimsService
    )
    {
        _configuration = configuration;
        _databaseContext = databaseContext;
        _claimsService = claimsService;
    }

    public async Task<string> SignIn(AuthDto login)
    {
        var user = await _databaseContext
                            .Users
                            .FirstOrDefaultAsync(u => u.Email == login.Email);

        var passwordMatches = BCrypt.Net.BCrypt.Verify(login.Password, user?.Password);

        if(user == null || !passwordMatches)
            return "Incorrect password!";
        

        return _claimsService.CreateToken(login);
    }
}