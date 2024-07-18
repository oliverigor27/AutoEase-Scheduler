using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Autoease.Domain.Dto;
using Microsoft.IdentityModel.Tokens;

namespace Autoease.Infrastructure.Claims;

public class ClaimsService
{
    private readonly IConfiguration _configuration;

    public ClaimsService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string CreateToken(AuthDto user)
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
            expires: DateTime.UtcNow.AddDays(7),
            signingCredentials: credentials
        );

        string jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }
}