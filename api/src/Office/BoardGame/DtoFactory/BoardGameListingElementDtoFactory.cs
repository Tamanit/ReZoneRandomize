using api.DataBase.Entity;
using api.Office.BoardGame.Dto;
using api.Shared.DtoFactory;

namespace api.Office.BoardGame.DtoFactory;

public class BoardGameListingElementDtoFactory
{
    private readonly FileDtoFactory _fileFactory = new();
    private readonly AgeRestrictionDtoFactory _ageRestrictionFactory = new();
    private readonly PlayerCountDtoFactory _playerCountFactory = new();
    private readonly DifficultyDtoFactory _difficultyFactory = new();


    public BoardGameListingElementDto Create(BoardGameEntity entity)
    {
        return new BoardGameListingElementDto(
            entity.Id,
            entity.Name,
            entity.Code,
            entity.Active,
            "/api/v1/office/boardGame/" + entity.Id,
            entity.Title,
            entity.PreviewImage == null ? null : _fileFactory.Create(entity.PreviewImage),
            entity.AgeRestriction == null ? null : _ageRestrictionFactory.Create(entity.AgeRestriction),
            entity.PlayerCount == null ? null : _playerCountFactory.Create(entity.PlayerCount),
            entity.Difficulty == null ? null : _difficultyFactory.Create(entity.Difficulty)
        );
    }

    public List<BoardGameListingElementDto> CreateList(List<BoardGameEntity> list)
    {
        return list.Select(Create).ToList();
    }
}
