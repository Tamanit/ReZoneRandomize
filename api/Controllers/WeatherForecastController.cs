using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/v1/HelloWorld")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Say()
    {
        return Ok("Hello World!");
    }
}