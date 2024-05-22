using api.DataBase.Repository;
using api.Shared.DtoFactory;
using Microsoft.AspNetCore.Mvc;

namespace api.Office.BoardGame.Controller;

[ApiController]
[Route("api/v1/office")]
public class PlayerCountController: ControllerBase
{
    [HttpGet]
    [Route("playerCount")]
    public IActionResult all()
    {
        return Ok(new PlayerCountDtoFactory().CreateCollection(new PlayerCountRepository().GetAll()));
    }
}
