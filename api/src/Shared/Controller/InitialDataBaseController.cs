using Microsoft.AspNetCore.Mvc;
using AppContext = api.DataBase.AppContext;

namespace api.Shared.Controller;

[ApiController]
[Route("api/v1/HelloWorld")]
public class InitialDataBaseController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Say()
    {
        var db = AppContext.GetInstance();
        return Ok("Db is ready! Hi!");
    }
}
