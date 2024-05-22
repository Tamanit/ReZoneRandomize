using api.DataBase.EntityFactory;
using api.DataBase.Repository;
using api.Office.BoardGame.Request;

namespace api.Office.BoardGame.Service;

public class BoardGameCreateOrUpdateService
{
    private readonly ValidateService _validateService = new();
    private readonly BoardGameRepository _boardGameRepository = new();
    private readonly BoardGameEntityFactory _entityFactory = new();
    
    public void Serve(CreateOrUpdateRequest request)
    {
        if (request.id == null)
        {
            _validateService.CreateBoardGameValidate(request);
            _boardGameRepository.Add(_entityFactory.Create((CreateRequest)request));
        }
        else
        {
            _boardGameRepository.Fetch(_entityFactory.Create((UpdateRequest)request)); 
        }
    }
}
