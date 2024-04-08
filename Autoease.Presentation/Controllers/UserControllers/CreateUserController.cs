using Autoease.Domain.Entities;
using Autoease.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Autoease.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateUserController : ControllerBase
    {
        private readonly ICreateUser _createUser;

        public CreateUserController(ICreateUser createUser)
        {
            _createUser = createUser;
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateUser(UserEntity user)
        {
            var data = await _createUser.NewUser(user);

            return Ok("User was created!");
        }
    }
}
