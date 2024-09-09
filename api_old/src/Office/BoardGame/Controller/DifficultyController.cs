using api.DataBase.Repository;
using api.Office.BoardGame.DtoFactory;
using Microsoft.AspNetCore.Mvc;

namespace api.Office.BoardGame.Controller;


[ApiController]
[Route("api/v1/office")]
public class DifficultyController: ControllerBase
{
    [HttpGet]
    [Route("difficulty")]
    public IActionResult all()
    {
        return Ok(new DifficultyDtoFactory().CreateCollection(new DifficultyRepository().GetAll()));
    }
}
