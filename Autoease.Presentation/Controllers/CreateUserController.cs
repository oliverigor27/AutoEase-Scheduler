using Autoease.Domain.Entities;
using Autoease.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Autoease.Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class CreateUserController : ControllerBase
{
    private ICreateUser _createUser;

    public CreateUserController(ICreateUser createUser)
    {
        _createUser = createUser;
    }

    [HttpGet("GetUser")]
    public ActionResult<List<User>> GetUsers()
    {
        return Ok(_createUser.GetAllUsers());
    }

    [HttpPost("New")]
    public ActionResult<User> Create(User user)
    {
        var newUser = _createUser.Create(user);
        return Ok(newUser);
    }
}
