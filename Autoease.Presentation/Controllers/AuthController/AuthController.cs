using System.Security.Authentication;
using Autoease.Domain.Dto;
using Autoease.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Autoease.Presentation.Controllers.AuthController;

[ApiController]
[Route("v1/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

[HttpPost]
public async Task<ActionResult<string>> Login(AuthDto login)
{
    try
    {
        string result = await _authService.SignIn(login);
        return Ok(result);
    }
    catch(AuthenticationException ex)
    {
        return BadRequest(ex.Message); // Retorna uma resposta de erro com a mensagem da exceção
    }
    catch(Exception)
    {
        return StatusCode(StatusCodes.Status500InternalServerError); // Lidar com outras exceções não tratadas
    }
}

}