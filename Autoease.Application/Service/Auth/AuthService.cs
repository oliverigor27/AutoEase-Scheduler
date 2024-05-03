using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Autoease.Domain.Dto;
using Autoease.Domain.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace Autoease.Application.Service.Auth;

public class AuthService : IAuthService
{
    private readonly IConfiguration _configuration;

    public AuthService(IConfiguration configuration)
    {
        _configuration = configuration;
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

    public Task<bool> SignIn(AuthDto login)
    {
        throw new NotImplementedException();
    }
}