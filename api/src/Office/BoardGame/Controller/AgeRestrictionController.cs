using api.DataBase.Repository;
using api.Shared.DtoFactory;
using Microsoft.AspNetCore.Mvc;

namespace api.Office.BoardGame.Controller;


[ApiController]
[Route("api/v1/office")]
public class AgeRestrictionController: ControllerBase
{
    
    [HttpGet]
    [Route("ageRestriction")]
    public IActionResult all()
    {
        return Ok(new AgeRestrictionDtoFactory().CreateCollection(new AgeRestrictionRepository().GetAll()));
    }
}