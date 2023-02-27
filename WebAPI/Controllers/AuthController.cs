using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Base;

namespace WebAPI.Controllers;

public class AuthController : BaseController
{
    [HttpPost]
    [Route("join")]
    public IActionResult Join()
    {
        return Ok();
    }
    
    [HttpPost]
    [Route("login")]
    public IActionResult Login()
    {
        return Ok();
    }

    [HttpDelete]
    [Route("logout")]
    public IActionResult Logout()
    {
        return Ok();
    }
}