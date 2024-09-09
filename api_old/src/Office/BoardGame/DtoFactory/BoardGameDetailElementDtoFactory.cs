using System.Net.Http.Headers;
using api.DataBase.Entity;
using api.Office.BoardGame.Dto;
using api.Shared.DtoFactory;

namespace api.Office.BoardGame.DtoFactory;

public class BoardGameDetailElementDtoFactory
{
    private readonly FileDtoFactory _fileFactory = new();
    private readonly AgeRestrictionDtoFactory _ageRestrictionFactory = new();
    private readonly PlayerCountDtoFactory _playerCountFactory = new();
    private readonly DifficultyDtoFactory _difficultyFactory = new();
    
    public BoardGameDetailElementDto Create(BoardGameEntity entity)
    {
        return new BoardGameDetailElementDto(
            entity.Id,
            entity.Name,
            entity.Code,
            entity.Active,
            entity.Title,
            entity.Description,
            entity.Rules,
            entity.PreviewImage == null ? null : _fileFactory.Create(entity.PreviewImage),
            entity.Images == null ? null : _fileFactory.CreateList(entity.Images),
            entity.AgeRestriction == null ? null : _ageRestrictionFactory.Create(entity.AgeRestriction),
            entity.PlayerCount == null ? null : _playerCountFactory.Create(entity.PlayerCount),
            entity.Difficulty == null ? null : _difficultyFactory.Create(entity.Difficulty)
        );
    }
}
