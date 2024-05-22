using api.Shared.DtoFactory;
using api.Shared.Errors;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api.Shared.Controller;

[ApiController]
[Route("")]
public class NotFoundController: ControllerBase
{
    private readonly ErrorDtoFactory _errorFactory = new();
    
    [HttpGet] [HttpDelete] [HttpHead] [HttpOptions] [HttpPatch] [HttpPost] [HttpPut]
    public IActionResult NonExpected()
    {
        return NotFound(_errorFactory.Create(new Error(ErrorCode.NotFound, 404, "Хмб вы уткнулись в тупик")));
    }
}
