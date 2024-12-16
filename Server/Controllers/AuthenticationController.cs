using BaseLibrary.DTOs;
using Microsoft.AspNetCore.Mvc;
using ServerLibrary.Repositories.Contracts;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController(IUserAccount accountInterface) : ControllerBase
{
    [HttpPost("register")]
    public async Task<IActionResult> CreateAsync(Register user)
    {
        if (user == null) return BadRequest("User is null");
        var result = await accountInterface.CreateAsync(user);
        return Ok(result);
    }
}