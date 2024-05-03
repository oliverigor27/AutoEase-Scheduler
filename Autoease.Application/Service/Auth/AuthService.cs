using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Autoease.Domain.Dto;
using Autoease.Domain.Interfaces;
using Autoease.Infrastructure.Persistence;
using Microsoft.IdentityModel.Tokens;

namespace Autoease.Application.Service.Auth;

public class AuthService : IAuthService
{
    private readonly IConfiguration _configuration;
    private readonly DatabaseContext _databaseContext;

    public AuthService(IConfiguration configuration, DatabaseContext databaseContext)
    {
        _configuration = configuration;
        _databaseContext = databaseContext;
    }

    private string CreateToken(AuthDto user)
    {
        List<Claim> claims = new()
        {
            new Claim(ClaimTypes.Email, user.Email)
        };

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value!
            )
        );

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(7),
            signingCredentials: credentials
        );

        string jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

    public async Task<string> SignIn(AuthDto login)
    {
        var user = await _databaseContext.Users.FindAsync(login.Email);

        var password = BCrypt.Net.BCrypt.Verify(user.Password, login.Password);

        if(user.Email != login.Email || !password)
        {
            return "Cannot be login in platform!";
        }

        string token = CreateToken(login);

        return token;
    }
}