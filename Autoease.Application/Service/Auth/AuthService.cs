using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Autoease.Domain.Dto;
using Autoease.Domain.Interfaces;
using Autoease.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
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
        var user = await _databaseContext.Users.FirstOrDefaultAsync(u => u.Email == login.Email);

        var passwordMatches = BCrypt.Net.BCrypt.Verify(login.Password, user.Password);

        if(user == null || !passwordMatches)
        {
            return "Incorrect password!";
        }

        string token = CreateToken(login);

        return token;
    }

}