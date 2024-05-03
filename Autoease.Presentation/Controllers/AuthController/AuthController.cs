using Microsoft.AspNetCore.Mvc;

namespace Autoease.Presentation.Controllers.AuthController;

[ApiController]
[Route("[controller]")]
public class AuthController
{

    [HttpPost]
    public ActionResult<string> signIn()
    {
        return "Retorno!";
    }
}