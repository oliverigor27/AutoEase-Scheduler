using Autoease.Domain.Entities;
using Autoease.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Autoease.Presentation.Controllers.UserController;

[ApiController]
[Route("[controller]")]
public class CreateUserController : ControllerBase
{
    private ICreateUser _createUser;

    public CreateUserController(ICreateUser createUser)
    {
        _createUser = createUser;
    }

    [HttpPost]
    public async Task<ActionResult<string>> createUser(UserEntity user)
    {
        var data = _createUser.CreateUser(user);

        return Ok("user");
    }
}