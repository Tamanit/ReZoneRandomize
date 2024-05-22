using api.DataBase.Repository;
using api.Office.BoardGame.Dto;
using api.Office.BoardGame.DtoFactory;
using api.Office.BoardGame.Request;

namespace api.Office.BoardGame.Service;

public class BoardGameDetailService
{
    private readonly BoardGameRepository _boardGameRepository = new();
    private readonly BoardGameDetailElementDtoFactory _boardGameFactory = new();
    
    public BoardGameDetailElementDto Serve(IdRequest request)
    {
        var entity = _boardGameRepository.Get(Guid.Parse(request.Id));

        entity = entity != null ? entity : throw new ArgumentNullException();
        
        return _boardGameFactory.Create(entity);
    }
}
