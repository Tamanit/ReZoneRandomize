using api.DataBase.Repository;
using api.Office.BoardGame.Request;

namespace api.Office.BoardGame.Service;

public class BoardGameDeleteService
{
    private readonly BoardGameRepository _boardGameRepository = new();
    
    public void Serve(IdRequest request)
    {
        _boardGameRepository.Remove(Guid.Parse(request.Id));
    }
}