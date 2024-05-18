using Autoease.Domain.Entities;
using Autoease.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Autoease.Presentation.Controllers.UserControllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateUserController : ControllerBase
    {
        private readonly IUserService _userService;

        public CreateUserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateUser(UserEntity user)
        {
            if (!user.IsValid())
            {
                return BadRequest(user.GetErrors());
            }

            var data = await _userService.NewUser(user);

            if (!data)
            {
                return BadRequest("Failed to create user.");
            }

            return Ok("User was created!");
        }

    }
}
