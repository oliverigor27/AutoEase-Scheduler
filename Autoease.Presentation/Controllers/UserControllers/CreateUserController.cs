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
            var data = await _userService.NewUser(user);

            return Ok("User was created!");
        }
    }
}
