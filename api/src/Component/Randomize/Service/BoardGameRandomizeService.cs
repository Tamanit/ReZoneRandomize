using api.DataBase.Repository;
using api.Engine.Database.DTO;

namespace api.Component.Randomize.Service;

public class BoardGameRandomizeService
{
    private readonly BoardGameRepository _boardGameRepository = new();
    private readonly BrunchRepository _brushRepository = new();
    
    public BoardGameDto GetRandomGame(string? branchName) => new(
        _boardGameRepository.GetRandomGameByBrunch(
            _brushRepository.FindByCode(branchName ?? "rezone")
            )
        );
}