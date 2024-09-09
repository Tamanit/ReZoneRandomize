using api.Component.Randomize.Service;
using Microsoft.AspNetCore.Mvc;

namespace api.Component.Randomize.Controller;

[ApiController]
[Route("api/v1")]
public class BoardGameRandomizeController: ControllerBase
{
    private BoardGameRandomizeService _boardGameRandomizeService = new();
    
    [HttpGet]
    [Route("random")]
    public IActionResult getRandomBoardGame([FromQuery] string? branch)
    {
        return Ok(_boardGameRandomizeService.GetRandomGame(branch));
    }
}