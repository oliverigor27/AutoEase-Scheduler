using Autoease.Domain.Dto;
using Autoease.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Autoease.Presentation.Controllers.AuthController;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost]
    public async Task<ActionResult<string>> SignIn(AuthDto login)
    {
        string result = await _authService.SignIn(login);

        return Ok(result);
    }
}