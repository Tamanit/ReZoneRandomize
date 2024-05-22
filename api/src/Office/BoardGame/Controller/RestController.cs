using api.DataBase.EntityFactory;
using api.Office.BoardGame.Request;
using api.Office.BoardGame.Service;
using api.Shared.DtoFactory;
using api.Shared.Errors;
using Microsoft.AspNetCore.Mvc;

namespace api.Office.BoardGame.Controller;

[ApiController]
[Route("api/v1/office")]
public class RestController: ControllerBase
{
    private readonly BoardGameListingService _listingService = new();
    private readonly BoardGameDetailService _detailService = new();
    private readonly BoardGameCreateOrUpdateService _createUpdateService = new();
    private readonly BoardGameDeleteService _deleteService = new();

    private readonly ErrorDtoFactory _errorDtoFactory = new();

    [HttpGet]
    [Route("boardGame/{Id}")]
    public IActionResult Detail([FromRoute] IdRequest request)
    {
        return Ok(_detailService.Serve(request));
    }
    
    [HttpGet]
    [Route("boardGames")]
    public IActionResult Listing([FromQuery] ListingRequest request)
    {
        return Ok(_listingService.Serve(request));
    }

    private readonly BoardGameEntityFactory _testFactory = new();
    
    [HttpPatch]
    [Route("boardGame/workbench")]
    public IActionResult CreateOrUpdate([FromBody] CreateOrUpdateRequest request)
    {
        try
        {
            _createUpdateService.Serve(request);
            return Ok();
        }
        catch (Error error)
        {
            return StatusCode(500, _errorDtoFactory.Create(error));
        }
         catch (Exception error)
         {
             return StatusCode(500,_errorDtoFactory.Create(error));
         }
    }

    [HttpDelete]
    [Route("boardGame/trashBin/{Id}")]
    public IActionResult Delete([FromRoute] IdRequest request)
    {
        try
        {
            _deleteService.Serve(request);
            return Ok();
        }
        catch (Exception error)
        {
            return StatusCode(500, _errorDtoFactory.Create(error));
        }
    }
}
